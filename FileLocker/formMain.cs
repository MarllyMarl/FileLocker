// Author: Marlon Dunn (KNASDMD)
// Date: 2018-24-08
// Copyright (c) 2018 MD INC.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using FileLocker.UtilityClass;

namespace FileLocker
{
    public partial class formMain : Form
    {
        // Global Variables
        #region Declarations

        string strFileToEncrypt;
        string strFileToDecrypt;
        string strOutputEncrypt;
        string strOutputDecrypt;
        FileStream fsInput;
        FileStream fsOutput;
        int errorNumber;
        List<string> thesefiles = new List<string>();

        #endregion

        #region Constructor
        public formMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Load
        private void formMain_Load(object sender, EventArgs e)
        {
            string version = Application.ProductVersion;
            this.Text = String.Format("File Locker v{0}", version);
        }

        #endregion

        #region Methods

        // Create A Key
        private byte[] CreateKey(string strPassword)
        {
            // Convert strPassword to an array and store in chrData.
            char[] chrData = strPassword.ToCharArray();
            // Use intLength to get strPassword size.
            int intLength = chrData.GetUpperBound(0);
            // Declare bytDataToHash and make it the same size as chrData.
            byte[] bytDataToHash = new byte[intLength + 1];

            // Use For Next to convert and store chrData into bytDataToHash.
            for (int i = 0; i <= chrData.GetUpperBound(0); i++)
                bytDataToHash[i] = System.Convert.ToByte((chrData[i]));

            // Declare what hash to use.
            System.Security.Cryptography.SHA512Managed SHA512 = new System.Security.Cryptography.SHA512Managed();
            // Declare bytResult, Hash bytDataToHash and store it in bytResult.
            byte[] bytResult = SHA512.ComputeHash(bytDataToHash);
            // Declare bytKey(31).  It will hold 256 bits.
            byte[] bytKey = new byte[32];

            // Use For Next to put a specific size (256 bits) of 
            // bytResult into bytKey. The 0 To 31 will put the first 256 bits
            // of 512 bits into bytKey.
            for (int i = 0; i <= 31; i++)
                bytKey[i] = bytResult[i];

            return bytKey; // Return the key.
        }

        // Create An IV
        private byte[] CreateIV(string strPassword)
        {
            // Convert strPassword to an array and store in chrData.
            char[] chrData = strPassword.ToCharArray();
            // Use intLength to get strPassword size.
            int intLength = chrData.GetUpperBound(0);
            // Declare bytDataToHash and make it the same size as chrData.
            byte[] bytDataToHash = new byte[intLength + 1];

            // Use For Next to convert and store chrData into bytDataToHash.
            for (int i = 0; i <= chrData.GetUpperBound(0); i++)
                bytDataToHash[i] = System.Convert.ToByte((chrData[i]));

            // Declare what hash to use.
            System.Security.Cryptography.SHA512Managed SHA512 = new System.Security.Cryptography.SHA512Managed();
            // Declare bytResult, Hash bytDataToHash and store it in bytResult.
            byte[] bytResult = SHA512.ComputeHash(bytDataToHash);
            // Declare bytIV(15).  It will hold 128 bits.
            byte[] bytIV = new byte[16];

            // Use For Next to put a specific size (128 bits) of 
            // bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
            // of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
            for (int i = 32; i <= 47; i++)
                bytIV[i - 32] = bytResult[i];

            return bytIV; // return the IV
        }

        // Encrypt / Decrypt
        private void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
        {
            try // In case of errors.
            {
                // Setup file streams to handle input and output.
                fsInput = new System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read);
                fsOutput = new System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
                fsOutput.SetLength(0); // make sure fsOutput is empty

                // Declare variables for encrypt/decrypt process.
                byte[] bytBuffer = new byte[4097]; // holds a block of bytes for processing
                long lngBytesProcessed = 0; // running count of bytes processed
                long lngFileLength = fsInput.Length; // the input file's length
                int intBytesInCurrentBlock; // current bytes being processed
                CryptoStream csCryptoStream = null;
                // Declare your CryptoServiceProvider.
                System.Security.Cryptography.RijndaelManaged cspRijndael = new System.Security.Cryptography.RijndaelManaged();
                // Setup Progress Bar
                pbStatus.Value = 0;
                pbStatus.Maximum = 100;

                // Determine if ecryption or decryption and setup CryptoStream.
                switch (Direction)
                {
                    case CryptoAction.ActionEncrypt:
                            csCryptoStream = new CryptoStream(fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
                            break;

                    case CryptoAction.ActionDecrypt:
                            csCryptoStream = new CryptoStream(fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
                            break;
                }

                // Use While to loop until all of the file is processed.
                while (lngBytesProcessed < lngFileLength)
                {
                    // Read file with the input filestream.
                    intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096);
                    // Write output file with the cryptostream.
                    csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock);
                    // Update lngBytesProcessed
                    lngBytesProcessed = lngBytesProcessed + System.Convert.ToInt64(intBytesInCurrentBlock);
                    // Update Progress Bar
                    pbStatus.Value = System.Convert.ToInt32((lngBytesProcessed / (double)lngFileLength) * 100);
                }

                // Close FileStreams and CryptoStream.
                csCryptoStream.Close();
                fsInput.Close();
                fsOutput.Close();

                // If encrypting then delete the original unencrypted file.
                if (Direction == CryptoAction.ActionEncrypt)
                {
                    FileInfo fileOriginal = new FileInfo(strFileToEncrypt);
                    fileOriginal.Delete();
                }

                // If decrypting then delete the encrypted file.
                if (Direction == CryptoAction.ActionDecrypt)
                {
                    FileInfo fileEncrypted = new FileInfo(strFileToDecrypt);
                    fileEncrypted.Delete();
                }

                // Update the user when the file is done.
                string wrap1 = " 13 ";
                string wrap2 = " 10 ";

                string Wrap = wrap1 + wrap2;
                if (Direction == CryptoAction.ActionEncrypt)
                {
                    //MessageBox.Show("Encryption Complete" + Wrap + Wrap + "Total bytes processed =  " + lngBytesProcessed.ToString(), "Done");
                    MessageBox.Show("Encryption Complete.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the progress bar and textboxes.
                    pbStatus.Value = 0;
                    txtFileToEncrypt.Text = "Click Browse to load file.";
                    txtPassEncrypt.Text = "";
                    txtConPassEncrypt.Text = "";
                    txtDestinationEncrypt.Text = "";
                    btnChangeEncrypt.Enabled = false;
                    btnEncrypt.Enabled = false;
                }
                else
                {
                    // Update the user when the file is done.
                    //MessageBox.Show("Decryption Complete" + Wrap + Wrap + "Total bytes processed =  " + lngBytesProcessed.ToString(), "Done");
                    MessageBox.Show("Decryption Complete.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the progress bar and textboxes.
                    pbStatus.Value = 0;
                    txtFileToDecrypt.Text = "Click Browse to load file.";
                    txtPassDecrypt.Text = "";
                    txtConPassDecrypt.Text = "";
                    txtDestinationDecrypt.Text = "";
                    btnChangeDecrypt.Enabled = false;
                    btnDecrypt.Enabled = false;
                }
            }

    
            // Catch file not found error.
            catch when (errorNumber == 53) // if file not found
            {
                MessageBox.Show("Please check to make sure the path and filename" + "are correct and if the file exists.", "Invalid Path or Filename");
            }

            // Catch all other errors. And delete partial files.
            catch
            {
                fsInput.Close();
                fsOutput.Close();

                if (Direction == CryptoAction.ActionDecrypt)
                {
                    FileInfo fileDelete = new FileInfo(txtDestinationDecrypt.Text);
                    fileDelete.Delete();
                    pbStatus.Value = 0;
                    txtPassDecrypt.Text = "";
                    txtConPassDecrypt.Text = "";

                    MessageBox.Show("Please check to make sure that you entered the correct" + " password.", "Invalid Password");
                }
                else
                {
                    FileInfo fileDelete = new FileInfo(txtDestinationEncrypt.Text);
                    fileDelete.Delete();

                    pbStatus.Value = 0;
                    txtPassEncrypt.Text = "";
                    txtConPassEncrypt.Text = "";

                    MessageBox.Show("This file cannot be encrypted.", "Invalid File");
                }
            }
        }

        // CryptoAction Enum
        private enum CryptoAction
        {
            // Define the enumeration for CryptoAction.
            ActionEncrypt = 1,
            ActionDecrypt = 2
        }

        #endregion

        #region Form Events

        //********************* ENCRYPT EVENT *********************************
        // Browse Encrypt Event
        private void btnBrowseEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Setup the open dialog.
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.FileName = "";
                openFileDialog.Title = "Choose a file to encrypt";
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "All Files (*.*) | *.*";
                //openFileDialog.Multiselect = true;

                // Find out if the user chose a file.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    strFileToEncrypt = openFileDialog.FileName;
                    txtFileToEncrypt.Text = strFileToEncrypt;

                    //foreach(string file in openFileDialog.FileNames)
                    //{
                    //    thesefiles.Add(file);
                    //}

                    int iPosition = 0;
                    int i = 0;

                     // Get the position of the last "\" in the OpenFileDialog.FileName path.
                    // -1 is when the character your searching for is not there.
                    // IndexOf searches from left to right.
                    while (strFileToEncrypt.IndexOf('\\', i) != -1)
                    {
                        iPosition = strFileToEncrypt.IndexOf('\\', i);
                        i = iPosition + 1;
                    }

                    // Assign strOutputFile to the position after the last "\" in the path.
                    // This position is the beginning of the file name.
                    strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1);
                    // Assign S the entire path, ending at the last "\".
                    string S = strFileToEncrypt.Substring(0, iPosition + 1);
                    // Replace the "." in the file extension with "_".
                    strOutputEncrypt = strOutputEncrypt.Replace('.', '_');
                    // The final file name.  XXXXX.encrypt
                    txtDestinationEncrypt.Text = S + strOutputEncrypt + ".encrypt";

                    // Enable buttons + textboxes.
                    btnEncrypt.Enabled = true;
                    btnChangeEncrypt.Enabled = true;
                    txtPassEncrypt.Enabled = true;
                    txtConPassEncrypt.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Change Encrypt Event
        private void btnChangeEncrypt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Select a folder to place the encrypted file in.";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestinationEncrypt.Text = folderBrowserDialog.SelectedPath + @"\" + strOutputEncrypt.Replace('_', '.');
            }
        }

        // Encrypt Button Event
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Textbox field validation
            if (string.IsNullOrEmpty(this.txtPassEncrypt.Text.Trim()))
            {
                MessageBox.Show("Password field cannot be empty.", "File Locker", MessageBoxButtons.OK);

                return;
            }

            // Textbox field validation
            if (string.IsNullOrEmpty(this.txtConPassEncrypt.Text.Trim()))
            {
                MessageBox.Show("Confirm password field cannot be empty.", "File Locker", MessageBoxButtons.OK);

                return;
            }
            else
            {
                if (txtConPassEncrypt.Text == txtPassEncrypt.Text)
                {
                    // Declare variables for the key and iv.
                    // The key needs to hold 256 bits and the iv 128 bits.
                    byte[] bytKey;
                    byte[] bytIV;
                    // Send the password to the CreateKey function.
                    bytKey = CreateKey(txtPassEncrypt.Text);
                    // Send the password to the CreateIV function.
                    bytIV = CreateIV(txtPassEncrypt.Text);
                    // Start the encryption.
                    EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt.Text, bytKey, bytIV, CryptoAction.ActionEncrypt);
                }
                else
                {
                    // Make sure the password is correct
                    MessageBox.Show("Passwords do not match.", "File Locker", MessageBoxButtons.OK);
                    txtPassEncrypt.Text = "";
                    txtConPassEncrypt.Text = "";
                }
            }
        }

        //********************* DECRYPT EVENT *********************************

        // Browse Decrypt Event
        private void btnBrowseDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Setup the open dialog.
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.FileName = "";
                openFileDialog.Title = "Choose a file to decrypt";
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "Encrypted Files (*.encrypt) | *.encrypt";
     
                // Find out if the user chose a file.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    strFileToDecrypt = openFileDialog.FileName;
                    txtFileToDecrypt.Text = strFileToDecrypt;

                    int iPosition = 0;
                    int i = 0;

                    // Get the position of the last "\" in the OpenFileDialog.FileName path.
                    // -1 is when the character your searching for is not there.
                    // IndexOf searches from left to right.
                    while (strFileToDecrypt.IndexOf('\\', i) != -1)
                    {
                        iPosition = strFileToDecrypt.IndexOf('\\', i);
                        i = iPosition + 1;
                    }

                    // strOutputFile = the file path minus the last 8 characters (.encrypt)
                    strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8);
                    // Assign S the entire path, ending at the last "\".
                    string S = strFileToDecrypt.Substring(0, iPosition + 1);
                    // Assign strOutputFile to the position after the last "\" in the path.
                    strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1));
                    // Replace "_" with "."
                    txtDestinationDecrypt.Text = S + strOutputDecrypt.Replace('_', '.');

                    // Enable buttons + textboxes.
                    btnDecrypt.Enabled = true;
                    btnChangeDecrypt.Enabled = true;
                    txtPassDecrypt.Enabled = true;
                    txtConPassDecrypt.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Change Decrypt Event
        private void btnChangeDecrypt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Select a folder to place the decrypted file in.";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestinationDecrypt.Text = folderBrowserDialog.SelectedPath + @"\" + strOutputDecrypt.Replace('_', '.');
            }
        }

        // Decrypt Button Event
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Textbox field validation
            if (string.IsNullOrEmpty(this.txtPassDecrypt.Text.Trim()))
            {
                MessageBox.Show("Password field cannot be empty.", "File Locker", MessageBoxButtons.OK);

                return;
            }

            // Textbox field validation
            if (string.IsNullOrEmpty(this.txtConPassDecrypt.Text.Trim()))
            {
                MessageBox.Show("Confirm password field cannot be empty.", "File Locker", MessageBoxButtons.OK);

                return;
            }
            else
            {
                // Make sure the password is correct
                if (txtConPassDecrypt.Text == txtPassDecrypt.Text)
                {
                    // Declare variables for the key and iv.
                    // The key needs to hold 256 bits and the iv 128 bits.
                    byte[] bytKey;
                    byte[] bytIV;
                    // Send the password to the CreateKey function.
                    bytKey = CreateKey(txtPassDecrypt.Text);
                    // Send the password to the CreateIV function.
                    bytIV = CreateIV(txtPassDecrypt.Text);
                    // Start the encryption.
                    EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt.Text, bytKey, bytIV, CryptoAction.ActionDecrypt);
                }
                else
                {
                    MessageBox.Show("Passwords do not match.", "File Locker", MessageBoxButtons.OK);
                    txtPassDecrypt.Text = "";
                    txtConPassDecrypt.Text = "";
                }
            }
        }


        //********************* ABOUT BOX EVENT *********************************

        // About Box link label Event
        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox aboutFileLocker = new AboutBox();
            aboutFileLocker.ShowDialog();
        }

        #endregion

    }
}
