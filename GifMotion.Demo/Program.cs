﻿using System;
using System.IO;
using System.Drawing;

namespace GifMotion.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string workingPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            // 33ms delay (~30fps)
            using (var gif = AnimatedGif.Create(workingPath + "/test.gif", 33))
            {
                var img = Image.FromFile(workingPath + "/forest.jpg");
                gif.AddFrame(img, delay: -1, quality: GIFQuality.Bit8);
            }
        }
    }
}