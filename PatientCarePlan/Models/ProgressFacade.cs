using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientCarePlan.Models
{
    class MainApp
    {
        public static void Main()
        {
            ProgressFacade facade = new ProgressFacade();

            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }

    class ViewActivity
    {
        public void ViewActivities()
        {
            Console.WriteLine("View Activity");
        }
    }

    class InsertNutritionInfo
    {
        public void InsertNutritionInfos()
        {
            Console.WriteLine("Insert Nutrition Info");
        }
    }

    class InsertBodyMeasurementInfo
    {
        public void InsertBodyMeasurementInfos()
        {
            Console.WriteLine("Inser Body Measurement Info");
        }
    }

    class InsertHealthRecord
    {
        public void InsertHealthRecords()
        {
            Console.WriteLine("Insert Health Record");
        }
    }

    class ProgressFacade
    {
        private ViewActivity _one;
        private InsertNutritionInfo _two;
        private InsertBodyMeasurementInfo _three;
        private InsertHealthRecord _four;

        public ProgressFacade()
        {
            _one = new ViewActivity();
            _two = new InsertNutritionInfo();
            _three = new InsertBodyMeasurementInfo();
            _four = new InsertHealthRecord();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            _one.ViewActivities();
            _two.InsertNutritionInfos();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            _three.InsertBodyMeasurementInfos();
            _four.InsertHealthRecords();
        }
    }
}