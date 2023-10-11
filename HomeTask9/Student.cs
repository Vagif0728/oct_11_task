//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace HomeTask9
//{
//    internal class Student
//    {
//        public string Name { get; set; }

//        public int Age { get; set; }

//        public int Grade { get; set; }


//        public string _name
//        {
//            get
//            {
//                return _name;
//            }
//            set
//            {
//              if(value != null)
//              {
//                    if( !( Regex.Match(value, "^[0-9][(.)(,)(?)]*$").Success))
//                    {
//                        if (Regex.Match(value, "^[A-Z][a-zA-Z]*$").Success)
//                        {
//                            Name = value;
//                        }
//                    }
                    
//                }
//            }
//        }

//        public int _age
//        {
//            get
//            {
//                return _age;
//            }
//            set
//            {
//                if(value>0 && value < 200)
//                {
//                    Age= value;
//                }
//            }
//        }

//        public int _grade
//        {
//            get
//            {
//                return _grade;
//            }
//            set
//            {
//                if(value>0 && value<100)
//                {
//                    Grade= value;
//                }
//            }
//        }

//        public Student(string name, int age, int grade)
//        {
//            _name = name;
//            _age = age;
//            _grade = grade;
           
//        }
//    }
//}
