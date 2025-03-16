using System;
using tpmodul5_103022300143;

class program
{
    static void Main()
    {
        HaloGeneric.sapaUser("angga nicola p");

        DataGeneric<string> data = new DataGeneric<string>("103022300143");
        data.PrintData();
    }
}