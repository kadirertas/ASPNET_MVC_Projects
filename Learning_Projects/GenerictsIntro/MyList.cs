using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerictsIntro
{
    internal class MyList<T>
    {
        T[] items;
         
        public MyList() { 
        
           items= new T[0];
        }


        public void Add(T item)
        {
            T[] tempArray = items;  /* eleman eklemeden önceki eski dizi kaybolmamamsı için onu
                                     geçici diziye adresliyorumki sonraondan o elemanları alayım */

            items = new T[items.Length+1];  /* elemanı ekleyebilmek için benim items adlı dizimi eleman sayısı 1 fazla olarak newlemem gerek
                                            satır21 de ki yaptığım şey x elemanlı dizi x+1 olarak newlendiğinde  x tane  eleman kaybolmasın diye   */
           
            


            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];                     /* görünen bu for döngüsünde ise "tempArray"i dolaş elelanları sırasıyla itemse ata
                                                                işlemini yapıyoruz  */
            }
        
           items[items.Length-1] = item;   // diziyi 10 elemanlı olarak newlediysen uzunluk -1 yani son elemana eklemek istediğin elemanı ekle 
        }



        public int Length  {


            get { return items.Length;  }

        
        }



    }
}
