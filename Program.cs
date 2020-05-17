using System;
using Facebook.Yoga;

namespace YogaTest
{
    internal static class Program
    {
        private static void Main()
        {
            var parent = new YogaNode
            {
                Width = YogaValue.Point(100),
                Height = YogaValue.Point(100),
                FlexDirection = YogaFlexDirection.Row,
                JustifyContent = YogaJustify.SpaceAround,
                AlignItems = YogaAlign.Center
            };

            var childA = new YogaNode
            {
                Width = YogaValue.Point(25),
                Height = YogaValue.Point(50)
            };

            var childB = new YogaNode
            {
                Width = YogaValue.Point(25),
                Height = YogaValue.Point(50),
                AlignSelf = YogaAlign.FlexEnd
            };

            parent.AddChild(childA);
            parent.AddChild(childB);

            parent.CalculateLayout();

            Console.WriteLine($"{parent.LayoutX} {parent.LayoutY} {parent.LayoutWidth} {parent.LayoutHeight}");
            Console.WriteLine($"{childA.LayoutX} {childA.LayoutY} {childA.LayoutWidth} {childA.LayoutHeight}");
            Console.WriteLine($"{childB.LayoutX} {childB.LayoutY} {childB.LayoutWidth} {childB.LayoutHeight}");
        }
    }
}