﻿using System;
using System.Windows.Media.Imaging;

namespace GifMotion
{
    public static class AnimatedGif
    {
        /// <summary>
        /// Create a new Animated GIF
        /// </summary>
        /// <param name="filePath">The Path where the Animated GIF gets saved</param>
        /// <param name="delay">Delay between frames</param>
        /// <param name="repeat">GIF Repeat count (0 meaning forever)</param>
        /// <returns></returns>
        public static GifCreator Create(string filePath, int delay, int repeat = 0) =>
            new GifCreator(filePath, delay, repeat);

        /// <summary>
        /// Load an Animated GIF from File (not yet custom implemented)
        /// </summary>
        /// <param name="filePath">Path to GIF File</param>
        /// <returns>GifBitmapDecoder using the GIF File</returns>
        public static GifBitmapDecoder Load(string filePath) => new GifBitmapDecoder(new Uri(filePath),
            BitmapCreateOptions.DelayCreation,
            BitmapCacheOption.Default);
    }
}