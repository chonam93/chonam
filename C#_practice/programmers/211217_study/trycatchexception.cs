using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211217_study
{
    class trycatchexception
    {
        static void Main(string[] args)
        {
            try
            {
                //실행하고자 하는 문장들
                DoSomething();
            }
            //try했다가 실패하면 에러를 잡는다!(catch)!  모든 예외를 일괄적으로 잡거나 혹은 특정 에외를 선별해서 잡을 수 있따
            catch (Exception ex)  // Exception ex >> 모든 에러잡느
            {
                //예외처리 / 로깅 등
               
            }
            catch (ArgumentException ex)
            {
                //argument 예외처리
            }
            catch (AccessViolationException ex)
            {
                //AccesViolation 예외처리
            }//catch문은 여러개 쓸 수 있음
            finally // 시도를해서 에러가 났건 말건 마지막으로 반드시 실행됨
            {
                //마지막으로 실행하는 문장
            }


            //throw :: catch문에서 exception 잡았는데 이를 다시 상위 호출자로 보내고 싶을때 사용
            try
            {
                // 실행 문장들
                Step1();
                Step2();
                Step3();
            }
            catch (IndexOutOfRangeException ex)
            {
                // 새로운 Exception 생성하여 throw
                throw new MyException("Invalid index", ex);
            }
            catch (FileNotFoundException ex)
            {
                bool success = Log(ex);
                if (!success)
                {
                    // 기존 Exception을 throw
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                Log(ex);
                // 발생된 Exception을 그대로 호출자에 전달
                throw;
            }



            //finall
            string connStr = "Data Source=(local);Integrated Security=true;";
            string sql = "SELECT COUNT(1) FROM sys.objects";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object count = cmd.ExecuteScalar();
                Console.WriteLine(count);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null &&
                    conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
1.Button
2.Combobox
3.GridController
4.PropertyGrid
5.LayoutControllrt