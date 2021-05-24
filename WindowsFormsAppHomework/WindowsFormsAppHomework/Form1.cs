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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 1;
            int b = 1;

            a = b++;
            Console.WriteLine(a); Console.WriteLine(b); Console.WriteLine();
            a = ++a;
            Console.WriteLine(a);




            //尚未連結資料庫，以初值給全域變數

            //顯示班級的下拉式選單           
            comboBoxMyClass.Items.Add(GlobalVar.myClass1.myClassName);
            comboBoxMyClass.Items.Add(GlobalVar.myClass2.myClassName);
            comboBoxMyClass.Items.Add(GlobalVar.myClass3.myClassName);
            comboBoxMyClass.SelectedIndex = 0;

            //顯示菜單種類的下拉式選單           
            comboBoxMenuName.Items.Add(GlobalVar.menu1.menuName);
            comboBoxMenuName.Items.Add(GlobalVar.menu2.menuName);
            comboBoxMenuName.Items.Add(GlobalVar.menu3.menuName);
            comboBoxMenuName.SelectedIndex = 0;

        }


        //將menu顯示在ListViewTEST (那個最大的框框)
        private void ShowListViewMenu(List<ArrayList> AL)
        {
            listViewMenuItem.Clear();
            listViewMenuItem.Columns.Add("#", 30);
            listViewMenuItem.Columns.Add("項目", 120);
            listViewMenuItem.Columns.Add("單價", 60);
            listViewMenuItem.Columns.Add("備註", 120);
            listViewMenuItem.Columns[2].TextAlign = HorizontalAlignment.Right;
            listViewMenuItem.Columns[3].TextAlign = HorizontalAlignment.Right;
            
            int count = 0;
            foreach (var item in AL)
            {               
                var temp = new ListViewItem($"{++count}");
                temp.SubItems.Add($"{item[0]}");
                temp.SubItems.Add($"{item[1]}元");
                listViewMenuItem.Items.Add(temp);
            }
        }

        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxStudentName.Text))
                MessageBox.Show(this, "請輸入姓名!", "訊息");
            
            else if (listViewMenuItem.SelectedItems.Count == 0) //選擇項目數為零 表示未選取
                MessageBox.Show(this, "請選擇項目!", "訊息");

            else
            {
                int tempIndex = listViewMenuItem.SelectedIndices[0];    //取得當前選取項目索引，若未選取這裡會報錯

                //---加入訂單(存到Order物件)---
                ArrayList tempAL = new ArrayList();
                string tempItem = listViewMenuItem.Items[tempIndex].SubItems[1].Text; //項目名稱
                int tempPriceEach = getStrInt(listViewMenuItem.Items[tempIndex].SubItems[2].Text);

                tempAL.Add(comboBoxStudentName.Text);
                tempAL.Add(tempItem);
                tempAL.Add(tempPriceEach);
                tempAL.Add(GlobalVar.tempMeal);
                tempAL.Add(GlobalVar.tempQuantity);
                tempAL.Add(GlobalVar.tempSubTotal);
                switch (comboBoxMyClass.SelectedIndex)
                {
                    case 0:
                        GlobalVar.order1.detail.Add(tempAL);
                        break;
                    case 1:
                        GlobalVar.order2.detail.Add(tempAL);
                        break;
                    case 2:
                        GlobalVar.order3.detail.Add(tempAL);
                        break;
                    default:
                        break;
                }
                //------



                //---跳出加入成功訊息窗---
                string caption = "訊息";
                string message = String.Format("成功加入訂單! 資訊如下:\n\n姓名: {0}\n項目: {1} {2}\n數量: {3}份\n小計: {4}元", comboBoxStudentName.Text, tempItem, GlobalVar.tempMeal, GlobalVar.tempQuantity , GlobalVar.tempSubTotal);
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Information);
                //------

                //---初始化---
                comboBoxStudentName.Text = "－－－";
                  //listViewMenuItem.SelectedItems[0].Selected = false;
                radioButton1.Checked = true;
                numericUpDownQuantity.Value = 1;
                //------
            }
            
            
        }


        private void comboBoxMyClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxStudentName.Text = "－－－";
            comboBoxStudentName.Items.Clear();
            string[] tempArray = { };
            switch (comboBoxMyClass.SelectedIndex)
            {
                case 0:
                    Array.Resize(ref tempArray, GlobalVar.myClass1.studentNameArray.Length);
                    GlobalVar.myClass1.studentNameArray.CopyTo(tempArray, 0);
                    break;

                case 1:
                    Array.Resize(ref tempArray, GlobalVar.myClass2.studentNameArray.Length);
                    GlobalVar.myClass2.studentNameArray.CopyTo(tempArray, 0);
                    break;

                case 2:
                    Array.Resize(ref tempArray, GlobalVar.myClass3.studentNameArray.Length);
                    GlobalVar.myClass3.studentNameArray.CopyTo(tempArray, 0);
                    break;

                default:
                    break;
            }

            foreach (var item in tempArray)
            {
                comboBoxStudentName.Items.Add(item);
            }
        }

        private void comboBoxMenuName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewMenuItem.Items.Clear();

            switch (comboBoxMenuName.SelectedIndex)
            {
                case 0:
                    ShowListViewMenu(GlobalVar.menu1.itemALList);
                    break;
                case 1:
                    ShowListViewMenu(GlobalVar.menu2.itemALList);
                    break;
                case 2:
                    ShowListViewMenu(GlobalVar.menu3.itemALList);
                    break;
                default:
                    break;
            }


        }

        
        


        //取字串中的數字
        public static int getStrInt(string msg)
        {
            int intStr = int.Parse(Regex.Replace(msg, "[^0-9]", ""));
            return intStr;
        }

        //設定GlobalVar.tempSubTotal
        private void SetAndShowSubTotal(object sender, EventArgs e)
        {
            GlobalVar.tempSubTotal = 0;
            if (listViewMenuItem.SelectedItems.Count == 0)
                labelSubTotal.Text = "0元";
            //else if (listViewMenuItem.SelectedItems.Count >= 2)
            //{
            //}
            else
            {
                //int tempIndex = listViewMenuItem.SelectedItems[0].Index;
                int tempIndex = listViewMenuItem.SelectedIndices[0];
                //Console.WriteLine("Selected:" + tempIndex);



                int tempPriceEach = getStrInt(listViewMenuItem.Items[tempIndex].SubItems[2].Text);
                int meal = 0;   //套餐加購價
                GlobalVar.tempQuantity = (int)numericUpDownQuantity.Value;
                if (radioButton1.Checked)
                {
                    GlobalVar.tempMeal = "　　　　　";
                    meal = 0;
                }
                else if (radioButton2.Checked)
                {
                    GlobalVar.tempMeal = "A餐(+30元)";
                    meal = 30;
                }


                GlobalVar.tempSubTotal += (tempPriceEach + meal) * GlobalVar.tempQuantity;
                labelSubTotal.Text = $"{GlobalVar.tempSubTotal}元";

            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Form2 formOrder = new Form2();
            //form訂購單列表.Show(); //不用show
            formOrder.ShowDialog();
        }


        //------------------------------------
        //listView失去焦點後(應該) SelectedItem顏色變反白  註:listViewMenuItem.HideSelection=true
        private void listViewMenuItem_Leave(object sender, EventArgs e)
        {
            //Console.WriteLine("AAA");
            if (listViewMenuItem.SelectedItems.Count == 1)
            {
                listViewMenuItem.SelectedItems[0].BackColor = SystemColors.Highlight;
                listViewMenuItem.SelectedItems[0].ForeColor = Color.White;
            }
        }


        //listView SelectedItem變更時  原SelectedItem顏色還原
        private void listViewMenuItem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SetAndShowSubTotal(sender,e);
            e.Item.ForeColor = Color.Black;
            e.Item.BackColor = SystemColors.Window;
        }


        //------------------------------------



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("即將關閉，未輸出的資料將遺失，確定繼續？", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false;  //關閉視窗
            }
            else
            {
                e.Cancel = true;    //取消關閉
            }
        }
    }

}
