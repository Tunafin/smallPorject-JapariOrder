using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHomework
{
    class MyClass
    {
        //班級名稱 e.g. 101 102 103 
        public string myClassName { get; set; }

        //學生名字集合
        public string[] studentNameArray { get; set; } = null;

        public MyClass(int myClassID)
        {
            
            string tempName;
            switch(myClassID)
            {
                
                case 1:
                    this.myClassName = "A班";
                    tempName = "謝百吟、林彥恬、楊慧玲、荊行光、陳信夫、白行峰、黃怡名、林昇伶、林夙凌、陳明慧";
                    studentNameArray = tempName.Split('、');
                    //foreach (var item in this.studentNameArray)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    break;

                case 2:
                    this.myClassName = "B班";
                    tempName = "鄭冠強、吳之均、林學為、吳婷婷、李珈緯、楊怡欣、宋志銘、陳盈堅、蘇桂陽、李俊泉";
                    studentNameArray = tempName.Split('、');
                    break;

                case 3:
                    this.myClassName = "C班";

                    //50個人
                    tempName = "陳昭珠、蔡俊德、楊翊茂、李明帆、錢翔芝、魏雅婷、郭軒豪、溫江善、黃志淳、黃雅隆、陳慧倫、鄭雅琪、吳淑貞、曾晴財、鄭怡婷、黃偉翔、狄秀慧、邱宥火、黃潔中、王冰胤、張賢睿、魏俊傑、林建文、周憶潔、陳慧湖、陳俊威、李雅盈、張士瑋、林鈺名、林正麟、林羽其、趙禮柏、蔡淑珍、童建宏、楊科星、沈美君、蔡璇蕙、吳欣盈、孫宜真、陳昱佩、吳宏偉、林柏婷、蔡容辰、張志偉、吳文南、張卉憲、朱心怡、駱方原、宋昇俐、陳信意";
                    studentNameArray = tempName.Split('、');
                    break;

            }
        }
    }
}
