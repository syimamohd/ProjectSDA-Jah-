using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientCarePlan.Models
{
    //Product participant
    abstract class NutritionFM { }

    //ConcreteProduct participant
    class Calcium : NutritionFM { }
    class Carbohydrate : NutritionFM { }
    class SaturatedFat : NutritionFM { }
    class Fiber : NutritionFM { }

    //Creator
    abstract class Nutritions
    {
        private List<NutritionFM> nutritions = new List<NutritionFM>();

        public Nutritions ()
        {
            createStandard ();
            createAdvance();
        }

        public abstract void createStandard();
        public abstract void createAdvance();

        public List <NutritionFM> NutritionFMs
        {
            get { return nutritions; }
        }
    }

    //ConcreteCreator
    class NutritionConcrete : Nutritions
    {
        public override void createAdvance()
        {
            NutritionFMs.Add(new Calcium());
            NutritionFMs.Add(new Carbohydrate());
            throw new NotImplementedException();
        }

        public override void createStandard()
        {
            NutritionFMs.Add(new SaturatedFat());
            NutritionFMs.Add(new Fiber());
            throw new NotImplementedException();
        }
    }


}