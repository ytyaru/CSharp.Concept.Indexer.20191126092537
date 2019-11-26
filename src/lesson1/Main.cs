using System;
using System.Collections.Generic;

namespace Concept.Indexer.Lesson1 {
    class Main {
        public void Run() {
            var n = new MappedNumber();
            Console.WriteLine($"{n[0,0]}");
            n[0,0] = 9;
            Console.WriteLine($"{n[0,0]}");
        }
    }
    class MappedNumber {
        int[,] nums;
        public MappedNumber() {
            nums = new int[2,2] {
                { 0, 1 }, { 2, 3 }
            };
        }
        public int this[int a, int b] {
            get { return nums[a,b]; }
            set { nums[a,b] = value; }
        }
    }
}
