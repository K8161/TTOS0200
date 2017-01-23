using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T3
{
    class Program
    {
        static void Main(string[] args)
        {
            // This doesn't work, object cannot be created from the abstract classes
            //DrawingObject do = new DrawingObject();

            Circle circle = new Circle();
            circle.Name = "My Circle";
            circle.Draw(); // "Draw Circle!"

            Square square = new Square();
            square.Name = "My Square";
            square.Draw(); // "Draw Square!"

            // create a list to store objects
            List<DrawingObject> drawingObjects = new List<DrawingObject>();
            // use polymorphis to store objects
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());

            Console.WriteLine("Loop through all drawing objects in a list:");
            foreach (DrawingObject drawingObject in drawingObjects)
            {
                drawingObject.Draw(); // "Draw Circle!" "Draw Square!" ...
            }
        }
    }
