using System;
using tpmodul5_103022300143;

class program
{
    static void Main()
    {
        HaloGeneric.sapaUser("nama");

        DataGeneric<string> data = new DataGeneric<string>("111");
        data.PrintData();
    }
}