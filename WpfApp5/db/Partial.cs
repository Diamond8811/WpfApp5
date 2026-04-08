using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp5.db
{
    public partial class Product
    {
        public string FullPhotoPath
        {
            get
            {
                if (PhotoPath != "")
                    return $"\\Images\\{PhotoPath}";
                else
                    return $"\\Images\\picture.png";
            }
        }
        public string ColorDiscountAndCount
        {
            get
            {
                if (Current_Discount > 15)
                {
                    return "#2E8B57";
                }
                else if (Coast == 0)
                {
                    return "#FF84F0EC";
                }
                return null;
            }
        }

        public string PriceOfDiscount
        {
            get
            {
                if (Current_Discount > 0)
                {
                    return $"{Price - (Price * Current_Discount / 100)}";
                }
                else
                {
                    return Price.ToString();
                }
            }
        }


        public Visibility PriceVisibility
        {
            get
            {
                if (Current_Discount == 0 )
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Visible;

                }
            }
        }
    }
}
