using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer IuC;
        }
    }

    public static class IuC
    {

    }

    public class FirstClass : IGetStringable
    {
        public String GetString()
        {
            return "First";
        }
    }

    public class SecondClass : IGetStringable
    {
        public String GetString()
        {
            return "Second";
        }
    }

    public interface IGetStringable
    {
        String GetString();
    }
}
