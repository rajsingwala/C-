using MVVM.Model;
using MVVM.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModel
{
    public class MainVM:CalcModel
    {
        private int value1 { get; set; }

        public int Value1
        {
            get { return value1; }
            set { value1 = value;
                OnPropertyChanged("Value1");
                }
        }
        
        private int value2 { set; get; }

        public int Value2
        {
            get { return value2; }
            set { value2 = value;
                
                OnPropertyChanged("Value2");
                }
        }
        
        private bool r1 { set; get; }

        public bool R1
        {
            get { return r1; }
            set { r1 = value;
                IsAnyChecked = true;
                OnPropertyChanged("R1");
                }
        }
        private bool r2 { set; get; }

        public bool R2
        {
            get { return r2; }
            set { r2 = value;
                IsAnyChecked = true;
                OnPropertyChanged("R2");
                }
        }
        private bool r3 { set; get; }

        public bool R3
        {
            get { return r3; }
            set { r3 = value;
                IsAnyChecked = true;
                OnPropertyChanged("R3");
                }
        }
        private bool r4 { set; get; }

        public bool R4
        {
            get { return r4; }
            set { r4 = value;
                IsAnyChecked = true;
                OnPropertyChanged("R4");
                }
        }

      
        public Calc cal { set; get; }
   

        private bool isAnyChecked;

        public bool IsAnyChecked
        {
            get { return isAnyChecked; }
            set { isAnyChecked = value;
                OnPropertyChanged("IsAnyChecked");        
                }
        }

        private int result;

        public int Result
        {
            get { return result; }
            set { result = value;
                OnPropertyChanged("Result");
            }
        }

        public ICommand Button_Clicked
        {
            get
            {
                return new DelegateCommand(FindResult);
            }
        }

        public void FindResult()
        {
            cal = new Calc(Value1, Value2);
            if (R1) Result = cal.Add();
            else if (R2) Result = cal.Sub();
            else if (R3) Result = cal.Mul();
            else if (R4) Result = cal.Div();
        }
    }
}
