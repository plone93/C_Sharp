using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DBTest.Bean;
using System.Data.SqlClient;
using System.Configuration;

namespace DBTest
{
    public class SelectTest
    {
        public List<BoardBean> selectBoard()
        {
            //DB접속 문자열 취득
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;//App.config에서 작성한 DB정보
            List<BoardBean> list = new List<BoardBean>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //DB에 접속
                    connection.Open();

                    //커맨드 생성
                    SqlCommand command = connection.CreateCommand();

                    //SQL 준비
                    command.CommandText = @"SELECT * 
                                        FROM examsite 
                                        WHERE boardId = @boardID";//커맨드 입력
                    //파라메터 정의
                    command.Parameters.AddWithValue("@boardId", "free");

                    using (SqlDataReader reader = command.ExecuteReader())//다중 레코드를 반환하는 쿼리
                    {
                        while (reader.Read() == true)//다음 레코드를 읽음, 레코드가 존재하지 않을때까지 반복
                        {
                            BoardBean bean = new BoardBean();//빈 생성
                            bean.BoardNum = Convert.ToInt32(reader["boardNum"]);//빈에 정보 입력
                            bean.BoardId = reader["boardId"] as string;
                            list.Add(bean);//리스트에 추가
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                    throw;
                }
            }

            return list;
        }



        public int insertBoard()
        {
            //DB접속 문자열 취득
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;//App.config에서 작성한 DB정보
            int resultCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //DB에 접속
                    connection.Open();

                    //커맨드 생성
                    SqlCommand command = connection.CreateCommand();

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
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                    throw;
                }
            }

            return resultCount;
        }



        public int deleteBoard()
        {
            //DB접속 문자열 취득
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;//App.config에서 작성한 DB정보
            int resultCount = 0;

            //SQL 준비
            string sql = @"DELETE FROM EXAMSITE
                           WHERE boardNum = @boardNum";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    //DB에 접속
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);

                    //파라메터 정의
                    command.Parameters.AddWithValue("@boardNum", 10);

                    //SQL 실행,실행된 행의 수를 반환
                    resultCount = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                    throw;
                }
            }

            return resultCount;
        }

        public void TranTest()
        {
            //DB접속 문자열 취득
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;//App.config에서 작성한 DB정보

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //DB에 접속
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    using (SqlCommand command = new SqlCommand() { Connection = connection, Transaction = transaction })
                    {
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
                        command.ExecuteNonQuery();

                        //SQL 준비
                        command.CommandText = @"INSERT INTO EXAMSITE(
                                        boardNum,
                                        boardId)
                                        VALUES(
                                        @boardNum,
                                        @boardId)";//커맨드 입력
                                                   //파라메터 정의
                        command.Parameters.AddWithValue("@boardNum", 11);
                        command.Parameters.AddWithValue("@boardId", "free");

                        //SQL 실행,실행된 행의 수를 반환
                        command.ExecuteNonQuery();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                    throw;
                }
            }
        }

    }
}
