using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
namespace uiuiui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void imgb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_Login_Click(object sender, EventArgs e)
        {
            string a; string b;
            a = txt_Username.Text;
            b = txt_Password.Text;

            if(isRightAcc(a,b))
            {
                
                    Menu mainMenu = new Menu();
                    mainMenu.Show();
                this.Hide();
            }
            else
            {
                EnterBillForm enterBillForm = new EnterBillForm();
                enterBillForm.Show();
                this.Hide();
            }
            

        }
        private bool isRightAcc(string username, string password)
        {
            if(File.Exists(Environment.CurrentDirectory + "\\acc.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = new FileStream(Environment.CurrentDirectory + "\\acc.bin", FileMode.Open, FileAccess.Read);
                
                    Account account = (Account)bf.Deserialize(file);
                    Dictionary<string, string> acc = account.accountList;
                if (acc.ContainsKey(username))
                {
                    if (acc[username] == password)
                    {
                        file.Close();
                        return true;
                    }
                    else
                    {
                        file.Close();
                        return false;
                    }
                }
                else
                {
                    file.Close();
                    return false;
                }
                
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = new FileStream("acc.bin", FileMode.Create, FileAccess.ReadWrite);
                Dictionary<string, string> account = new Dictionary<string, string>();
                account.Add("admin", "1");
                Account acc = new Account(account);
                bf.Serialize(file, acc);
                file.Close();
                return false;
            }
        }
       
    }
    [Serializable]
    public class Account
    {
        public Dictionary<string, string> accountList { get; }
        public Account(Dictionary<string,string> accList)
        {
            accountList = accList;
        }
        public Account(string username, string password)
        {
            accountList.Add(username, password);
        }
        public Account()
        {
            accountList = new Dictionary<string, string>();
            accountList.Add("admin", "1");
        }
    }
}
