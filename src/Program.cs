using System;

class Program
{
    static void Main()
    {
        Run0();
        Run1();
        Run2();
        Run3();
        Run4();
        Run5();
        Run6();
        Run7();
    }
    static void Run0() { int[] a = new int[3]; }
    static void Run1() { int[,] a = new int[3,5]; }
    static void Run2() { int[,,] a = new int[3,5,2]; }
    static void Run3() {
        int[][] a = new int[3][];
        a[0] = new int[10];
        a[1] = new int[5];
        a[2] = new int[20];
    }
    static void Run4() { int[] a = new int[] { 1, 2, 3 }; }
    static void Run5() { int[] a = { 1, 2, 3 }; }
    static void Run6() {
        int[] t = new int[3];
        t[0] = 1;
        t[1] = 2;
        t[2] = 3;
        int[] a = t;
    }
    static void Run7() {
        /*
        int[] a = int[3]; // newがない。error CS1525
        int[] a = new int[3](); // ()が余計。error CS0149
        int a[] = new int[3]; // []は型の後ろ。error CS0650
        int[][] a = new int[3][4]; // 多次元ならカンマ区切り。error CS0178
        */
    }
}
