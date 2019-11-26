using System;
using System.Collections.Generic;

namespace Concept.Indexer.Lesson0 {
    class Main {
        public void Run() {
            var n = new NamedNumber();
            Console.WriteLine($"{n["A"]}, {n["B"]}");
            n["A"] = 9;
            Console.WriteLine($"{n["A"]}, {n["B"]}");
        }
    }
    class NamedNumber {
        Dictionary<string, int> dict;
        public NamedNumber() {
            dict = new Dictionary<string, int>() {
                ["A"] = 0,
                ["B"] = 1,
            };
        }
        public int this[string key] {
            get { return dict[key]; }
            set { dict[key] = value; }
        }
    }
}
