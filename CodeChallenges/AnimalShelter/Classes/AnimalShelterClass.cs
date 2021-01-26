using System;
using System.Collections.Generic;
using System.Text;
using StackandQueue;

namespace AnimalShelter
{
    public class AnimalShelterClass
    {
        public Animal Front { get; set; }
        public Animal Back { get; set; }

        /// <summary>
        /// Adds an animal to the back of the shelter list
        /// </summary>
        /// <param name="animal"></param>
        public void Enqueue(Animal animal)
        {

            if (animal.GetType() == typeof(Dog) || animal.GetType() == typeof(Cat))
            {
                if (Front == null)
                {
                    Front = animal;
                    Back = animal;
                }
                else
                {
                    Back.Next = animal;
                    Back = animal;
                }
            }
        }

        /// <summary>
        /// Gets the animal based of a preffered type
        /// </summary>
        /// <param name="pref"></param>
        public Animal Dequeue(string pref)
        {
            try
            {
                Animal animal = Back;

                if (animal.GetType() == typeof(Dog))
                {
                    Back = Back.Next;
                    animal.Next = null;
                    return animal;
                }
                else
                {
                    return null;
                }
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }
    }
}

