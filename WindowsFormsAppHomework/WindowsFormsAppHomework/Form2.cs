using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHomework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //尚未連結資料庫，以初值給全域變數

            //顯示班級的下拉式選單
            comboBoxMyClass.Items.Add(GlobalVar.myClass1.myClassName);
            comboBoxMyClass.Items.Add(GlobalVar.myClass2.myClassName);
            comboBoxMyClass.Items.Add(GlobalVar.myClass3.myClassName);
            comboBoxMyClass.SelectedIndex = 0;

            //設定日期
            labelDate.Text = $"日期: {DateTime.Now:yyyy/MM/dd}";

            listViewDetail.Columns.Add("#", 30);
            listViewDetail.Columns.Add("姓名", 60);
            listViewDetail.Columns.Add("項目", 120);
            listViewDetail.Columns.Add("升級", 90);
            listViewDetail.Columns.Add("數量", 45);
            listViewDetail.Columns.Add("小計", 75);
            listViewDetail.Columns[5].TextAlign = HorizontalAlignment.Right;

            listViewStatistics.Columns.Add("項目", 120);
            listViewStatistics.Columns.Add("數量", 60);
            listViewStatistics.Columns[1].TextAlign = HorizontalAlignment.Right;



        }


        private void ShowListViewDetail(List<ArrayList> AL)
        {
            GlobalVar.tempTotalAll = 0;



            listViewDetail.Items.Clear();
            

            listViewStatistics.Items.Clear();
            



            int count = 0;
            foreach (var item in AL)
            {
                var temp = new ListViewItem($"{++count:D2}");
                temp.SubItems.Add($"{item[0]}"); //姓名
                temp.SubItems.Add($"{item[1]}"); //項目
                temp.SubItems.Add($"{item[3]}"); //升級
                temp.SubItems.Add($"{item[4]}份"); //數量
                temp.SubItems.Add($"{item[5],4}元"); //小計
                listViewDetail.Items.Add(temp);
                GlobalVar.tempTotalAll += (int)item[5];
                //------

                //-----------Statistics----------------------------------------------------------------------------
                bool myBool = false;
                for (int i = 0; i < listViewStatistics.Items.Count; i++)
                {
                    //Console.WriteLine($"{item[1]}   {listViewStatistics.Items[i].SubItems[0].Text}");
                    if ((string)item[1] == listViewStatistics.Items[i].SubItems[0].Text)
                    {
                        listViewStatistics.Items[i].SubItems[1].Text = $"{(getStrInt(listViewStatistics.Items[i].SubItems[1].Text) + (int)item[4]),3}份";
                        myBool = true;
                        break;
                    }
                }
                if (!myBool)
                {
                    //Console.WriteLine($"NEW");
                    var temp2 = new ListViewItem($"{item[1]}"); //項目
                    temp2.SubItems.Add($"{item[4],3}份"); //數量
                    listViewStatistics.Items.Add(temp2);
                }
                //-----------Statistics----------------------------------------------------------------------------    
            }

            //-----------Statistics(A)----------------------------------------------------------------------------    
            

            if (listViewStatistics.Items.Count > 1)
            {
                listViewStatistics.Items.Add("------");

                count = 0;
                foreach (var item in AL)
                {
                    if (((string)item[3]).Contains("A餐"))
                        count += (int)item[4];
                }
                var temp3 = new ListViewItem($"*升級A餐"); //項目
                temp3.SubItems.Add($"{count,3}份"); //數量
                listViewStatistics.Items.Add(temp3);
            }
            
            //-----------Statistics(A)----------------------------------------------------------------------------    


            SetRecordAndTotal();

        }
        private void comboBoxMyClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listViewDetail.Items.Clear();

            switch (comboBoxMyClass.SelectedIndex)
            {
                case 0:
                    ShowListViewDetail(GlobalVar.order1.detail);
                    break;      
                case 1:         
                    ShowListViewDetail(GlobalVar.order2.detail);
                    break;      
                case 2:         
                    ShowListViewDetail(GlobalVar.order3.detail);
                    break;
                default:
                    break;
            }
        }

        //------------------------------------
        //listView失去焦點後(應該) SelectedItem顏色變反白  註:listViewMenuItem.HideSelection=true
        private void listViewDetail_Leave(object sender, EventArgs e)
        {
            if (listViewDetail.SelectedItems.Count == 1)
            {
                listViewDetail.SelectedItems[0].BackColor = SystemColors.Highlight;
                listViewDetail.SelectedItems[0].ForeColor = Color.White;
            }
        }


        //listView SelectedItem變更時  原SelectedItem顏色還原
        private void listViewDetail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            e.Item.ForeColor = Color.Black;
            e.Item.BackColor = SystemColors.Window;
        }
//------------------------------------------------------------------------------------------------------------

        private void SetRecordAndTotal()
        {
            labelRecord.Text = $"總筆數: {listViewDetail.Items.Count,3}筆";
            labelTotalAll.Text = $"{GlobalVar.tempTotalAll,5}元";
        }

        //取字串中的數字
        public static int getStrInt(string msg)
        {
            int intStr = int.Parse(Regex.Replace(msg, "[^0-9]", ""));
            return intStr;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listViewDetail.SelectedItems.Count == 0)
            {
                if(listViewDetail.Items.Count==0)
                    MessageBox.Show("訂購單為空!", "訊息");
                else
                    MessageBox.Show("未選擇項目!", "訊息");
            }
            else
            {
                DialogResult result = MessageBox.Show("將刪除選擇項目，確定嗎?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    int index = listViewDetail.SelectedIndices[0];

                    //傘班級標記
                    if (comboBoxMyClass.SelectedIndex == 0) GlobalVar.order1.detail.RemoveAt(index);
                    else if (comboBoxMyClass.SelectedIndex == 1) GlobalVar.order2.detail.RemoveAt(index);
                    else if (comboBoxMyClass.SelectedIndex == 2) GlobalVar.order3.detail.RemoveAt(index);

                    //-------------------Statistics---------------
                    for (int i = 0; i < listViewStatistics.Items.Count; i++)
                    {

                        if(listViewStatistics.Items[i].SubItems[0].Text == listViewDetail.SelectedItems[0].SubItems[2].Text)
                        {
                            
                            int tempNum = getStrInt(listViewStatistics.Items[i].SubItems[1].Text) - getStrInt(listViewDetail.SelectedItems[0].SubItems[4].Text);
                            if(listViewDetail.SelectedItems[0].SubItems[3].Text.Contains("A餐"))
                            {
                                int tempNumA = getStrInt(listViewStatistics.Items[listViewStatistics.Items.Count - 1].SubItems[1].Text) - getStrInt(listViewDetail.SelectedItems[0].SubItems[4].Text);
                                if(tempNumA==0)
                                {
                                    listViewStatistics.Items[listViewStatistics.Items.Count - 1].Remove();
                                    listViewStatistics.Items[listViewStatistics.Items.Count - 1].Remove();
                                }
                                else
                                    listViewStatistics.Items[listViewStatistics.Items.Count - 1].SubItems[1].Text = $"{tempNumA,3}份";
                            }

                            if (tempNum == 0)
                            {
                                if (listViewStatistics.Items.Count > 1)
                                {
                                    listViewStatistics.Items[i].Remove();

                                }
                                else
                                    listViewStatistics.Items.Clear();
                            }
                            else
                                listViewStatistics.Items[i].SubItems[1].Text = $"{tempNum,3}份";



                        }
                    }

                    //-------------------Statistics(A)---------------


                GlobalVar.tempTotalAll -= getStrInt(listViewDetail.Items[index].SubItems[5].Text);
                    listViewDetail.Items[index].Remove();

                    

                    //重製 #編號
                    int count = 0;
                    for (int i = 0; i < listViewDetail.Items.Count; i++)
                        listViewDetail.Items[i].SubItems[0].Text = $"{++count:D2}";


                    


                    SetRecordAndTotal();
                    MessageBox.Show("已刪除選擇項目!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if(listViewDetail.Items.Count==0)
                MessageBox.Show("訂購單為空!", "訊息", MessageBoxButtons.OK);
            else
            {
                DialogResult result = MessageBox.Show("將刪除所有項目，確定嗎?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if(result== DialogResult.Yes)
                {
                    
                    //傘班級標記
                    if (comboBoxMyClass.SelectedIndex == 0) GlobalVar.order1.detail.Clear();
                    else if (comboBoxMyClass.SelectedIndex == 1) GlobalVar.order2.detail.Clear();
                    else if (comboBoxMyClass.SelectedIndex == 2) GlobalVar.order3.detail.Clear();

                    listViewDetail.Items.Clear();
                    listViewStatistics.Items.Clear();
                    GlobalVar.tempTotalAll = 0;

                    SetRecordAndTotal();
                    
                    MessageBox.Show("已刪除所有項目!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            if (listViewDetail.Items.Count == 0)
            {
                MessageBox.Show("訂購單為空!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string str檔案路徑 = @"";
            Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyyyMMddHHmmss") + myNum + ".txt";
            string str完整路徑名稱 = str檔案路徑 + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
                str完整路徑名稱 = sfd.FileName;
            else
                return;

            //-------------------------------------------
            //Console.WriteLine(str完整路徑名稱);
            List<string> list訂購品項輸出 = new List<string>();

            list訂購品項輸出.Add("        <<<<<<<<    Welcome to Japari Park!!    >>>>>>>>        ");
            list訂購品項輸出.Add("----------------------------------------------------------------");
            list訂購品項輸出.Add("");
            list訂購品項輸出.Add("訂購班級:" + comboBoxMyClass.Text);
            list訂購品項輸出.Add($"日期: {DateTime.Now:D}");
            list訂購品項輸出.Add("");
            list訂購品項輸出.Add("");
            list訂購品項輸出.Add("");

            list訂購品項輸出.Add(labelRecord.Text);
            list訂購品項輸出.Add("================================================================");
            list訂購品項輸出.Add("");

            for (int i = 0; i < listViewDetail.Items.Count; i++)
            {
                var temp = listViewDetail.Items[i];
                string id = temp.SubItems[0].Text;
                string 姓名 = temp.SubItems[1].Text;
                string 品項 = temp.SubItems[2].Text;
                string 升級 = temp.SubItems[3].Text;
                string 數量 = temp.SubItems[4].Text;
                string 小計 = temp.SubItems[5].Text;
                string str訂購品項資訊 = string.Format($"{id,2}  {姓名}  {品項}  {升級}  {數量}  {小計}");
                list訂購品項輸出.Add(str訂購品項資訊);
            }

            list訂購品項輸出.Add("");
            list訂購品項輸出.Add("================================================================");
            list訂購品項輸出.Add("");
            list訂購品項輸出.Add($"總價: {labelTotalAll.Text}");
            list訂購品項輸出.Add("");

            list訂購品項輸出.Add("----------------------------------------------------------------");

            System.IO.File.WriteAllLines(str完整路徑名稱, list訂購品項輸出, Encoding.UTF8);
            MessageBox.Show("存檔成功 !!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
