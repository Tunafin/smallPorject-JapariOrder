using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHomework
{
    class GlobalVar
    {

        //未使用資料庫，以此暫代
        //創建班級物件
        public static MyClass myClass1 = new MyClass(1);
        public static MyClass myClass2 = new MyClass(2);
        public static MyClass myClass3 = new MyClass(3);

        //創建菜單物件
        public static Menu menu1 = new Menu(1);
        public static Menu menu2 = new Menu(2);
        public static Menu menu3 = new Menu(3);



        //創建訂單物件(含明細 統計)
        public static Order order1 = new Order(1);
        public static Order order2 = new Order(2);
        public static Order order3 = new Order(3);

        public static string tempMeal = "單點";
        public static int tempQuantity = 0;
        public static int tempSubTotal = 0;
        public static int tempTotalAll = 0;


    }
}
