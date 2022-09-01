using Microsoft.VisualBasic;
using Serilog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace PodLoad
{
    public partial class PodForm : Form
    {
        //Create global variables for logging, data table, app version, temp and archive files.
        //Since file paths are hardcoded they will need to be changed here and in SyncButton_Click (and log path changed in Program.cs) whenever a change needs to be made.
        ILogger podformLog;
        DataTable dt = new DataTable();
        string appVersion = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title + Assembly.GetExecutingAssembly().GetName().Version;
        string fileName = Application.StartupPath  + "/Data/Temp/Temp.xml";

        //Initial function to initialize the form, saves the passed log into the global and creates a new XML file for temp storage of values.
        public PodForm(ILogger log)
        {
            try
            {
                podformLog = log;
                InitializeComponent();
                CreateFile(true);
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'PodForm' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to return the selected mode (upload or download).
        private string ActionValue()
        {
            try
            {
                if (downloadingButton.Checked)
                {
                    return "DOWNLOAD";
                }
                else
                {
                    return "UPLOAD";
                }
            }
            catch(Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'ActionValue' function. Restart the application and try again or contact your system administrator if the problem persists");
                return null;
            }
        }

        //Function to change the available range options in the drop down menu. Changes values if in upload or download mode.
        private void ChangeRangeOptions(bool cond)
        {
            try
            {
                rangeInput.Items.Clear();
                if (cond)
                {
                    rangeInput.Items.Add("N/A");
                    rangeInput.SelectedIndex = 0;

                }
                else
                {
                    rangeInput.Items.Add("LOCAL");
                    rangeInput.Items.Add("RF");
                    rangeInput.Items.Add("GF WEST");
                    rangeInput.Items.Add("NTTR/UTTR");
                    rangeInput.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'ChangeRangeOptions' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to change the available station options in the drop down menu. Changes values based on the selected input in the aircraftInput text field.
        private void ChangeStationOptions(object sender, EventArgs e)
        {
            try
            {
                stationInput.Items.Clear();
                if (aircraftInput.Text == "F-15C" || aircraftInput.Text == "F-15E")
                {
                    stationInput.Items.Add("8O");
                    stationInput.Items.Add("8I");
                    stationInput.Items.Add("2O");
                    stationInput.Items.Add("2I");
                }
                else if (aircraftInput.Text == "F-16")
                {
                    stationInput.Items.Add("9");
                    stationInput.Items.Add("8A");
                    stationInput.Items.Add("2A");
                    stationInput.Items.Add("1");
                }
                else if (aircraftInput.Text == "F-18E" || aircraftInput.Text == "F-18G")
                {
                    stationInput.Items.Add("8O");
                    stationInput.Items.Add("8I");
                    stationInput.Items.Add("2O");
                    stationInput.Items.Add("2I");
                }
                else
                {
                    stationInput.Items.Add("1");
                    stationInput.Items.Add("2");
                    stationInput.Items.Add("3");
                    stationInput.Items.Add("4");
                    stationInput.Items.Add("5");
                    stationInput.Items.Add("6");
                    stationInput.Items.Add("7");
                    stationInput.Items.Add("8");
                    stationInput.Items.Add("9");
                }
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'ChangeStationOptions' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to check if inputed value is a integer or not. If not do not accept value.
        private void CheckIfInt(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'CheckIfInt' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to clear the text boxes on the form and input the default values depending on the data entry mode it is currently in (upload/download).
        private void ClearSelections()
        {
            try
            {
                if (!uploadingButton.Checked)
                {
                    unitInput.Text = "N/A";
                    aircraftInput.Text = "N/A";
                    tailnoInput.Text = "N/A";
                    podnoInput.Text = String.Empty;
                    drdnoInput.Text = "N/A";
                    stationInput.Text = "N/A";
                    ChangeRangeOptions(true);
                    torqueInput.Text = "N/A";
                    codeInput.SelectedIndex = -1;
                    commentBox.Text = String.Empty;
                }
                else
                {
                    unitInput.Text = String.Empty;
                    aircraftInput.Text = String.Empty;
                    tailnoInput.Text = String.Empty;
                    podnoInput.Text = String.Empty;
                    drdnoInput.Text = String.Empty;
                    stationInput.Text = String.Empty;
                    ChangeRangeOptions(false);
                    torqueInput.Text = String.Empty;
                    codeInput.SelectedIndex = -1;
                    commentBox.Text = String.Empty;
                }

                tdyBox.Checked = false;
                statusmreqButton.Checked = true;
                statussprButton.Checked = false;
                weightedBox.Checked = false;
                effectiveBox.Checked = false;
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'ClearSelections' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to create the temp XML file for storing inputed values. If the file exists it uses that to populate the dataviewgrid, if not then create a new file and generate the schema.
        private void CreateFile(bool start)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    dt.ReadXml(fileName);
                    displayedTable.DataSource = dt;
                }
                else if (start)
                {
                    Directory.CreateDirectory(Application.StartupPath + "/Data/Temp/");
                    dt.TableName = "PodFormTable";
                    dt.Columns.Add("WorkShift", typeof(string));
                    dt.Columns.Add("Unit", typeof(string));
                    dt.Columns.Add("TDY", typeof(bool));
                    dt.Columns.Add("AircraftType", typeof(string));
                    dt.Columns.Add("TailNO", typeof(string));
                    dt.Columns.Add("AircraftStatus", typeof(string));
                    dt.Columns.Add("PodNO", typeof(string));
                    dt.Columns.Add("Weighted", typeof(bool));
                    dt.Columns.Add("DRDNO", typeof(string));
                    dt.Columns.Add("TorqueWrench", typeof(string));
                    dt.Columns.Add("Station", typeof(string));
                    dt.Columns.Add("Range", typeof(string));
                    dt.Columns.Add("ConditionCode", typeof(string));
                    dt.Columns.Add("NotEffective", typeof(bool));
                    dt.Columns.Add("Comments", typeof(string));
                    dt.Columns.Add("Timestamp", typeof(DateTime));
                    dt.Columns.Add("ActionType", typeof(string));
                    dt.WriteXml(fileName, XmlWriteMode.WriteSchema);
                }
                else
                {
                    dt.Clear();
                    dt.WriteXml(fileName, XmlWriteMode.WriteSchema);
                }
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'CreateFile' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to clear the selection after databinding on the datagridview.
        private void Datagridview_ClearSelection(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                displayedTable.ClearSelection();
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'Datagridview_ClearSelection' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to change the row color depending on the input mode. Pastel green for upload and pastel red for download.
        private void Datagridview_Color(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in displayedTable.Rows)
                {
                    if (row.Cells["ActionType"].Value.ToString() == "DOWNLOAD")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
                    }
                }

                displayedTable.ClearSelection();
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'Datagridview_Color' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to delete the selected row in the datagridview and also deletes the respective node in the XML file.
        private void Datagridview_Delete(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {      
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);
                xmlDoc.DocumentElement.RemoveChild(xmlDoc.DocumentElement.ChildNodes[e.Row.Index + 1]);
                xmlDoc.Save(fileName);
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'Datagridview_Delete' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to clear the current selection in the datagridview when clicked on an empty part of the table.
        private void Datagridview_Deselect(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if (displayedTable.HitTest(e.X, e.Y) == DataGridView.HitTestInfo.Nowhere)
                    {
                        displayedTable.ClearSelection();
                        displayedTable.CurrentCell = null;
                    }
                }
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'Datagridview_Deselect' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to check if all of the "Done" boxes are checked, if not then do not submit results until box is checked or row is deleted.
        private bool? Datagridview_Done()
        {
            try
            {
                foreach (DataGridViewRow row in displayedTable.Rows)
                {
                    if (row.Cells["Done"].Value == null || !(bool)row.Cells["Done"].Value)
                    {
                        MessageBox.Show("The 'Done' box needs to be checked on every row to sync. Either check the box on each row or delete the row to continue");
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'Datagridview_Done' function. Restart the application and try again or contact your system administrator if the problem persists");
                return null;
            }
        }

        //Function to all user to edit data in datagridview if check box is checked. If unchecked then table returns to "read-only" mode. First column always needs to not be in "read-only" mode.
        private void Datagridview_Edit(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewColumn column in displayedTable.Columns)
                {
                    if (editBox.Checked)
                    {
                        column.ReadOnly = false;
                    }
                    else
                    {
                        column.ReadOnly = true;
                    }
                }

                displayedTable.Columns[0].ReadOnly = false;
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'Datagridview_Edit' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function for when the input mode is changed (upload/download). Function disables/enables inputs respective of mode and clears previous inputs.
        private void InputModeChange_Click(object sender, EventArgs e)
        {
            try
            {
                unitInput.Enabled = uploadingButton.Checked;
                tdyBox.Checked = false;
                tdyBox.Enabled = uploadingButton.Checked;
                aircraftInput.Enabled = uploadingButton.Checked;
                tailnoInput.Enabled = uploadingButton.Checked;
                statusmreqButton.Checked = uploadingButton.Checked;
                statusmreqButton.Enabled = uploadingButton.Checked;
                statussprButton.Checked = false;
                statussprButton.Enabled = uploadingButton.Checked;
                weightedBox.Checked = false;
                weightedBox.Enabled = uploadingButton.Checked;
                drdnoInput.Enabled = uploadingButton.Checked;
                stationInput.Enabled = uploadingButton.Checked;
                rangeInput.Enabled = uploadingButton.Checked;
                torqueInput.Enabled = uploadingButton.Checked;
                effectiveBox.Checked = false;
                effectiveBox.Enabled = !uploadingButton.Checked;
                ClearSelections();
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'InputModeChange_Click' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function for when the save button is clicked. If any fields are empty require a input before continuing, else input values into datagridview and XML file and clear fields for new input.
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (unitInput.Text == String.Empty ||
                    aircraftInput.Text == String.Empty ||
                    tailnoInput.Text == String.Empty ||
                    podnoInput.Text == String.Empty ||
                    drdnoInput.Text == String.Empty ||
                    stationInput.Text == String.Empty ||
                    rangeInput.Text == String.Empty ||
                    torqueInput.Text == String.Empty ||
                    ShiftValue() == String.Empty ||
                    codeInput.Text == String.Empty)
                {
                    MessageBox.Show("You cannot leave any fields empty");
                }
                else
                {
                    dt.Rows.Add(new Object[]
                    {
                        ShiftValue(),
                        unitInput.Text,
                        tdyBox.Checked,
                        aircraftInput.Text,
                        tailnoInput.Text,
                        StatusValue(),
                        podnoInput.Text,
                        weightedBox.Checked,
                        drdnoInput.Text,
                        torqueInput.Text,
                        stationInput.Text,
                        rangeInput.Text,
                        codeInput.Text.Substring(0, 4),
                        effectiveBox.Checked,
                        commentBox.Text,
                        DateTime.UtcNow,
                        ActionValue()
                    });

                    dt.AcceptChanges();
                    displayedTable.AutoGenerateColumns = false;
                    displayedTable.DataSource = dt;
                    dt.WriteXml(fileName, XmlWriteMode.WriteSchema);

                    ClearSelections();
                    displayedTable.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'SaveButton_Click' function. Restart the application and try again or contact your system administrator if the problem persists");
            }
        }

        //Function to return the respective shift string value dependant on button that is checked. If not value then return and empty string.
        private string ShiftValue()
        {
            try
            {
                if (shift1Button.Checked)
                {
                    return "SHIFT1";
                }
                else if (shift2Button.Checked)
                {
                    return "SHIFT2";
                }
                else if (shift3Button.Checked)
                {
                    return "SHIFT3";
                }
                else if (shift4Button.Checked)
                {
                    return "WKND";
                }

                return String.Empty;
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'ShiftValue' function. Restart the application and try again or contact your system administrator if the problem persists");
                return null;
            }
        }

        //Function to return the respective status string value dependant on button that is checked. If not value then return null.
        private string StatusValue()
        {
            try
            {
                if (statusmreqButton.Checked)
                {
                    return "MR";
                }
                else if (statussprButton.Checked)
                {
                    return "SP";
                }

                return "N/A";
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'StatusValue' function. Restart the application and try again or contact your system administrator if the problem persists");
                return null;
            }
        }

        //Function to format the string by stripping all whitespace, special characters and uppercasing all chars.
        private string StringFormat(string str)
        {
            try
            {
                string tempStr = Regex.Replace(str, "[^a-zA-Z0-9_.]+", "");
                tempStr = Regex.Replace(tempStr, @"\s+", "");
                return tempStr.ToUpper();
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'StringFormat' function. Restart the application and try again or contact your system administrator if the problem persists");
                return null;
            }
        }

        //Function to send results to the database via SQL queries, then archives the temp XML file by moving it to a new directory and renaming it with the timestamp of sync.
        private void SyncButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((bool)Datagridview_Done())
                {
                    syncBar.Visible = true;
                    syncBar.Value = 35;
                    string userInput = UserAuthenication();

                    if (userInput != String.Empty)
                    {
                        string connectionString = "Data Source=DESKTOP-A1NT5EG\\SQLEXPRESS;Initial Catalog=PodLoad;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        SqlConnection connectDB = new SqlConnection(connectionString);
                        connectDB.Open();

                        foreach (DataRow row in dt.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                if (row["ActionType"].ToString() == "DOWNLOAD")
                                {
                                    SqlCommand downQuery = new SqlCommand("INSERT INTO dbo.PodLoad_DOWNLOAD (AppVersion, Timestamp, WorkShift, PodNO, ConditionCode, NotEffective, Comments, Authorizer, UpdateGUID) VALUES (@appVersion, @Timestamp, @shiftInput, @podnoInput, @codeInput, @effectiveInput, @commentInput, @userInput, @updateGUID)", connectDB);
                                    downQuery.Parameters.AddWithValue("@appVersion", appVersion);
                                    downQuery.Parameters.AddWithValue("@Timestamp", row["Timestamp"].ToString());
                                    downQuery.Parameters.AddWithValue("@shiftInput", StringFormat(row["WorkShift"].ToString()));
                                    downQuery.Parameters.AddWithValue("@podnoInput", StringFormat(row["PodNO"].ToString()));
                                    downQuery.Parameters.AddWithValue("@codeInput", StringFormat(row["ConditionCode"].ToString().Substring(0, 4)));
                                    downQuery.Parameters.AddWithValue("@effectiveInput", row["NotEffective"].ToString());
                                    if (row["Comments"].ToString() == String.Empty)
                                    {
                                        downQuery.Parameters.AddWithValue("@commentInput", "BLANK");
                                    }
                                    else
                                    {
                                        downQuery.Parameters.AddWithValue("@commentInput", row["Comments"].ToString());
                                    }
                                    downQuery.Parameters.AddWithValue("@userInput", userInput);
                                    downQuery.Parameters.AddWithValue("@updateGUID", Guid.Empty);
                                    downQuery.ExecuteNonQuery();
                                }
                                else
                                {
                                    SqlCommand upQuery = new SqlCommand("INSERT INTO dbo.PodLoad_UPLOAD (AppVersion, Timestamp, WorkShift, Unit, TDY, AircraftType, TailNO, AircraftStatus, PodNO, Weighted, DRDNO, TorqueWrench, Station, Range, ConditionCode, NotEffective, Comments, Authorizer, UpdateGUID) VALUES (@appVersion, @Timestamp, @shiftInput, @unitInput, @tdyInput, @aircraftInput, @tailnoInput, @statusInput, @podnoInput, @weightedInput, @drdnoInput, @torqueInput, @stationInput, @rangeInput, @codeInput, @effectiveInput, @commentInput, @userInput, @updateGUID)", connectDB);
                                    upQuery.Parameters.AddWithValue("@appVersion", appVersion);
                                    upQuery.Parameters.AddWithValue("@Timestamp", row["Timestamp"].ToString());
                                    upQuery.Parameters.AddWithValue("@shiftInput", StringFormat(row["WorkShift"].ToString()));
                                    upQuery.Parameters.AddWithValue("@unitInput", StringFormat(row["Unit"].ToString()));
                                    upQuery.Parameters.AddWithValue("@tdyInput", row["TDY"]);
                                    upQuery.Parameters.AddWithValue("@aircraftInput", StringFormat(row["AircraftType"].ToString()));
                                    upQuery.Parameters.AddWithValue("@tailnoInput", StringFormat(row["TailNO"].ToString()));
                                    upQuery.Parameters.AddWithValue("@statusInput", StringFormat(row["AircraftStatus"].ToString()));
                                    upQuery.Parameters.AddWithValue("@podnoInput", StringFormat(row["PodNO"].ToString()));
                                    upQuery.Parameters.AddWithValue("@weightedInput", row["Weighted"]);
                                    upQuery.Parameters.AddWithValue("@drdnoInput", StringFormat(row["DRDNO"].ToString()));
                                    upQuery.Parameters.AddWithValue("@torqueInput", StringFormat(row["TorqueWrench"].ToString()));
                                    upQuery.Parameters.AddWithValue("@stationInput", StringFormat(row["Station"].ToString()));
                                    upQuery.Parameters.AddWithValue("@rangeInput", StringFormat(row["Range"].ToString()));
                                    upQuery.Parameters.AddWithValue("@codeInput", StringFormat(row["ConditionCode"].ToString().Substring(0, 4)));
                                    upQuery.Parameters.AddWithValue("@effectiveInput", row["NotEffective"]);
                                    if (row["Comments"].ToString() == String.Empty)
                                    {
                                        upQuery.Parameters.AddWithValue("@commentInput", "BLANK");
                                    }
                                    else
                                    {
                                        upQuery.Parameters.AddWithValue("@commentInput", row["Comments"].ToString());
                                    }
                                    upQuery.Parameters.AddWithValue("@userInput", userInput);
                                    upQuery.Parameters.AddWithValue("@updateGUID", Guid.Empty);
                                    upQuery.ExecuteNonQuery();
                                }
                            }
                        }

                        string moveFile = Application.StartupPath + "/Data/Archive/" + string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}.xml", DateTime.UtcNow);
                        File.Move(fileName, moveFile);
                        CreateFile(false);
                        syncBar.Value = 100;
                        MessageBox.Show("Sync Complete");
                        syncBar.Visible = false;
                        connectDB.Close();
                    }
                    else
                    {
                        MessageBox.Show("You must enter your name to submit these records, please try again");
                        syncBar.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'SyncButton_Click' function. Restart the application and try again or contact your system administrator if the problem persists");
                syncBar.Visible = false;
            }
        }

        //Function that recieves a user's input via InputBox and strips any whitespace and uppercases the entry and returns the modified value.
        private string UserAuthenication()
        {
            try
            {
                string userInput = Interaction.InputBox("Please enter your first initial, period, then last name below (Ex: A.Kim)");
                return Regex.Replace(userInput, @"\s+", "").ToUpper();
            }
            catch (Exception ex)
            {
                podformLog.Error(ex.ToString());
                MessageBox.Show("There was a failure in the 'UserAuthenication' function. Restart the application and try again or contact your system administrator if the problem persists");
                return null;
            }
        }

        private void CAC_Credentials()
        {/*
            var Certs = new List<X509Certificate2>();
            var test = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            test.Open(OpenFlags.ReadWrite);
           
            if (test.Certificates[0] != null)
            {
                X509Certificate2 cert = test.Certificates[0];
                string test3 = cert.Subject;
                MessageBox.Show("NAME: " +  test3);
                test.Remove(cert);
            }
            test.Close();*/
        }
    }
}
