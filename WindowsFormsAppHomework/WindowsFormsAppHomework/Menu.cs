using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHomework
{
    class Menu
    {
        

        //建構函式
        public Menu(int menuID)
        {
            ArrayList tempAL = new ArrayList();
            tempAL.Clear();
            switch(menuID)
            {
                case 1:
                    this.menuName = "好難吃便當";
                    tempAL.Add("招牌飯　　"); tempAL.Add(60); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("豬排飯　　"); tempAL.Add(80); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("雞腿飯　　"); tempAL.Add(100); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("鮭魚飯　　"); tempAL.Add(120); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("鮭魚卵飯　"); tempAL.Add(180); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("？？？　　"); tempAL.Add(500); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    break;
                case 2:
                    this.menuName = "好軟爛炒飯";
                    tempAL.Add("招牌蛋炒飯"); tempAL.Add(55); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("番茄蛋炒飯"); tempAL.Add(60); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("肉絲蛋炒飯"); tempAL.Add(70); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("火腿蛋炒飯"); tempAL.Add(80); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("鮭魚蛋炒飯"); tempAL.Add(120); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    break;
                case 3:
                    this.menuName = "好噁心咖哩";
                    tempAL.Add("招牌咖哩　"); tempAL.Add(65); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("豬排咖哩　"); tempAL.Add(90); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("雞腿排咖哩"); tempAL.Add(110); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    tempAL.Add("鮭魚卵咖哩"); tempAL.Add(200); this.itemALList.Add(new ArrayList(tempAL)); tempAL.Clear();
                    break;

            }
            

        }

        public string menuName { get; set; }

        // item  unitPrice  custom
        public List<ArrayList> itemALList = new List<ArrayList>();
    }
}
