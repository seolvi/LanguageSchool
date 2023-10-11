using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace LanguageSchool.Components
{
    public partial class Service
    {
        public decimal CostDiscount
        {
            get
            {
                if (Discount == 0)
                    return Cost;
                else 
                    return Cost - (Cost *(decimal)Discount/100);
            }
        }
  
        public string costTimeStr
        {
            get
            {
                if (Discount == 0)
                    return $" {Cost:0} рублей за {DurationInSeconds / 60} минут";
                else
                    return $" {Cost - (Cost * (decimal)Discount / 100):0} рублей за {DurationInSeconds / 60} минут";


            }
        }
        public Visibility CostVisibility
        {
            get
            {
                if (Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }

        public string DiscountStr
        {
            get
            {
                if (Discount == 0)
                    return null;
                else
                    return $"* скидка {Discount}%";
            }
        }
      
        public System.Windows.Media.Brush ColorDiscount
        {
            get
            {
                if (Discount == 0)
                    return new SolidColorBrush(Colors.White);
                else
                    return new SolidColorBrush(Colors.LightGreen);
            }
        }
    }
}
