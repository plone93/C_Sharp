using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using DBTest.Bean;

namespace DBTest
{
    class Program
    {

        static void Main(string[] args)
        {

            //DB접속 문자열 취득
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;//App.config에서 작성한 DB정보
            int resultCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())//커맨드 생성
            {
                //DB에 접속
                connection.Open();

                //SQL 준비
                command.CommandText = @"INSERT INTO EXAMSITE(
                                        boardNum,
                                        boardId)
                                        VALUES(
                                        @boardNum,
                                        @boardId)";//커맨드 입력
                //파라메터 정의
                command.Parameters.AddWithValue("@boardNum", 10);
                command.Parameters.AddWithValue("@boardId", "free");

                //SQL 실행,실행된 행의 수를 반환
                resultCount = command.ExecuteNonQuery();
            }




            /*트랜잭션처리 : 여러테이블 */

            //DB접속 문자열 취득
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //DB에 접속
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    using (var command = new SqlCommand() { Connection = connection, Transaction = transaction })
                    {
                        try
                        {
                            //SQL 준비
                            command.CommandText = @"SELECT * 
                                        FROM examsite 
                                        WHERE boardId = @boardID";
                            command.Parameters.AddWithValue("@boardId", "free");

                            //SQL 실행
                            command.ExecuteNonQuery();

                            //SQL 준비
                            command.CommandText = @"SELECT * 
                                        FROM examsite 
                                        WHERE boardId = @boardID";
                            command.Parameters.AddWithValue("@boardId", "free");

                            //SQL 실행
                            command.ExecuteNonQuery();

                            //커밋
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
