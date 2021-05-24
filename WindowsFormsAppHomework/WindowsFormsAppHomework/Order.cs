using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHomework
{
    class Order
    {
        //建構函式
        public Order(int orderID)
        {
            switch (orderID)
            {
                case 1:
                    this.myClass = GlobalVar.myClass1.myClassName;
                    break;
                case 2:
                    this.myClass = GlobalVar.myClass2.myClassName;
                    break;
                case 3:
                    this.myClass = GlobalVar.myClass3.myClassName;
                    break;
                default:
                    break;
            }
        }



        //訂購班級
        public string myClass { set; get; }
        /*   自動實作屬性，只保留存取子set和get
         *   編譯器會自動支援private欄位
         */

        
        //  訂單明細
        //  訂購人    品項     單價       客製化    數量     小計  
        //  name     item   PriceEach   custom  quantity  subPrice
        public List<ArrayList> detail = new List<ArrayList>();


        //訂單統計
        //     品項       數量     
        //     item     quantity 
        //    升級A餐      10     
        public List<ArrayList> statistics = new List<ArrayList>();
        

        //訂單總價
        //public int totalAll { set; get; } = 0;






    }


}
