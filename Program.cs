using System;
using System.Collections.Generic;

namespace Branches
{
    public class Branch
    {
        public char Letter { get; set; }
        private List<Branch> branches;

        public Branch(char letter)
        {
            Letter = letter;
            branches = new List<Branch>();
        }

        public Branch GetBranch(int index) { return branches[index]; }

        public void Add(Branch branch) { branches.Add(branch); }

        public int Count() { return branches.Count; }
    }

    class Program
    {
        static int MaxHeight(Branch branch)
        {
            int height = 1;

            if (branch.Count() == 0) return height;

            for(int i = 0; i < branch.Count(); i++)
            {
                height = Math.Max(height, MaxHeight(branch.GetBranch(i)));
            }

            return height+1;
        }

        //                       A
        //
        //                     /   \
        //
        //                   B       C
        //
        //                 /      /  |  \
        //
        //               D      E    F    G
        //
        //                    /    /   \    \
        //
        //                  H     I     J     K
        //
        //                        |
        //
        //                        L

        static void Main(string[] args)
        {
            Branch branch = new Branch('A');
            branch.Add(new Branch('B'));
            branch.Add(new Branch('C'));
            branch.GetBranch(0).Add(new Branch('D'));
            branch.GetBranch(1).Add(new Branch('E'));
            branch.GetBranch(1).Add(new Branch('F'));
            branch.GetBranch(1).Add(new Branch('G'));
            branch.GetBranch(1).GetBranch(0).Add(new Branch('H'));
            branch.GetBranch(1).GetBranch(1).Add(new Branch('I'));
            branch.GetBranch(1).GetBranch(1).Add(new Branch('J'));
            branch.GetBranch(1).GetBranch(2).Add(new Branch('K'));
            branch.GetBranch(1).GetBranch(1).GetBranch(0).Add(new Branch('L'));

            Console.WriteLine(MaxHeight(branch));
        }
    }
}
