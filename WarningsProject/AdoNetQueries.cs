using Sap.Data.Hana;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarningsProject
{
    class dataFromOINS
    {
        public string insID { get; set; }

        public string custmrName { get; set; }
        public string itemName { get; set; }
        public string internalSN { get; set; }

        public string customer { get; set; }
        public string itemCode { get; set; }
        public string createDate { get; set; }

        public string docEntry { get; set; }
    }

    class AdoNetQueries
    {
        public string IdUniq = DateTime.Now.ToString("yyyyMMddHHmmssfff");


        private static HanaConnection connection;
        //Data Source=WIN-BJUAU770ANM\SILA;initial catalog=Company_TS;Integrated Security=False;User ID=sa;Password=Sila123456!;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False
        static AdoNetQueries()
        {
            connection = new HanaConnection("Server=HanaB1:30015;Database=BRANCHES_EURO;UserName=SYSTEM;Password=Qazwsx123;Current Schema=BRANCHES_EURO");
        }

        public static Form1.allFields[][] whereFormIsOpenMatrix0(string insID)
        {
            Form1.allFields[][] dataForTables = new Form1.allFields[2][];

            using (HanaCommand command = new HanaCommand() { Connection = connection })
            {
                command.CommandText = string.Format(@"select * from ""BRANCHES_EURO"".""@ACC_PAINTS_IT"" where ""U_insID""={0}", insID);
                connection.Open();
                
                    using (HanaDataAdapter da = new HanaDataAdapter(command.CommandText, connection))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataForTables[0] = new Form1.allFields[dt.Rows.Count];
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dataForTables[0][i].code1 = dt.Rows[i]["U_Code"].ToString();
                                dataForTables[0][i].title = dt.Rows[i]["U_Name"].ToString();

                                dataForTables[0][i].photo = dt.Rows[i]["U_Picture"].ToString();
                                dataForTables[0][i].serialNumber = dt.Rows[i]["U_SerialNumber"].ToString();
                                dataForTables[0][i].articul = dt.Rows[i]["U_Articul"].ToString();
                                dataForTables[0][i].EAN = dt.Rows[i]["U_EAN"].ToString();

                                dataForTables[0][i].instDate = dt.Rows[i]["U_InstDate"] != DBNull.Value ? Convert.ToDateTime(dt.Rows[i]["U_InstDate"]).ToString("yyyyMMdd") : null;
                                dataForTables[0][i].srokExpl = dt.Rows[i]["U_LifeTime"].ToString();
                                dataForTables[0][i].snDate = dt.Rows[i]["U_drDownDate"] != DBNull.Value ? Convert.ToDateTime(dt.Rows[i]["U_drDownDate"]).ToString("yyyyMMdd") : null; //dt.Rows[i]["U_drDownDate"].ToString();
                                dataForTables[0][i].comment = dt.Rows[i]["U_Comment"].ToString();

                                dataForTables[0][i].warning = dt.Rows[i]["U_Warning"].ToString();
                                dataForTables[0][i].charact = dt.Rows[i]["U_Characteristics"].ToString();
                                dataForTables[0][i].modif = dt.Rows[i]["U_Modification"].ToString();

                                dataForTables[0][i].insID = dt.Rows[i]["U_insID"].ToString();
                            }
                        }
                    }
                
                    connection.Close();
            }
            
            using (HanaCommand command = new HanaCommand() { Connection = connection })
            {
                //command.CommandText = @"select * from ""BRANCHES_EURO"".""@ACC_PAINTS_ITEMS_2""";
                //command.CommandText += string.Format(@"where ""U_insID""='{0}'", insID);
                command.CommandText = string.Format(@"select * from ""BRANCHES_EURO"".""@ACC_PAINTS_ITEMS_2"" where ""U_insID""={0}", insID);
                connection.Open();
               
                    using (HanaDataAdapter da = new HanaDataAdapter(command.CommandText, connection))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataForTables[1] = new Form1.allFields[dt.Rows.Count];
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dataForTables[1][i].code1 = dt.Rows[i]["U_code"].ToString();
                                dataForTables[1][i].title = dt.Rows[i]["U_TitlePaint"].ToString();

                                dataForTables[1][i].batchNumber = dt.Rows[i]["U_BatchNumber"].ToString();
                                dataForTables[1][i].articul = dt.Rows[i]["U_Articul"].ToString();
                                dataForTables[1][i].EAN = dt.Rows[i]["U_EAN"].ToString();
                                dataForTables[1][i].createDate = dt.Rows[i]["U_ManufDate"].ToString();

                                dataForTables[1][i].shipingDate = dt.Rows[i]["U_DeliveryDate"].ToString();
                                dataForTables[1][i].srokExpl = dt.Rows[i]["U_ShelfLife"].ToString();

                                dataForTables[1][i].docEntry = dt.Rows[i]["U_DocEntry"].ToString();

                                dataForTables[1][i].comment = dt.Rows[i]["U_Comment"].ToString();
                                dataForTables[1][i].warning = dt.Rows[i]["U_Warning"].ToString();

                                dataForTables[1][i].insID = dt.Rows[i]["U_insID"].ToString();
                            }
                        }
                    }
                }
                
                    connection.Close();
                
            

            return dataForTables;
        }

        public static dataFromOINS GetEqCard(string id)
        {
            dataFromOINS dataOINS = new dataFromOINS();
            //List<dataFromOINS> serviceCallsArr = new List<dataFromOINS>();
            using (HanaCommand command = new HanaCommand() { Connection = connection })
            {
                command.CommandText = @"select * from ""OINS""";
                command.CommandText += string.Format(@"where ""insID""='{0}'", id);

                connection.Open();
                
                    using (HanaDataAdapter da = new HanaDataAdapter(command.CommandText, connection))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dataOINS.customer = dt.Rows[i]["customer"].ToString();
                                dataOINS.itemCode = dt.Rows[i]["itemCode"].ToString();

                                dataOINS.internalSN = dt.Rows[i]["internalSN"].ToString();
                                dataOINS.custmrName = dt.Rows[i]["custmrName"].ToString();
                                dataOINS.itemName = dt.Rows[i]["itemName"].ToString();
                                dataOINS.createDate = dt.Rows[i]["createDate"].ToString();

                                dataOINS.docEntry = dt.Rows[i]["U_DocEntry"].ToString();
                                dataOINS.insID = dt.Rows[i]["insID"].ToString();
                            }
                        }
                    }
                
                    connection.Close();
                
                return dataOINS;
            }
        }

        public static string getAbsEntry(string id)
        {
            string result = "";
            //List<dataFromOINS> serviceCallsArr = new List<dataFromOINS>();
            using (HanaCommand command = new HanaCommand() { Connection = connection })
            {
                command.CommandText = @"select ""AbsEntry"" from ""OBTN""";
                command.CommandText += string.Format(@"where ""DistNumber""='{0}'", id);

                connection.Open();
                
                    using (HanaDataAdapter da = new HanaDataAdapter(command.CommandText, connection))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            result = dt.Rows[0]["AbsEntry"].ToString();
                        }
                    }
                
                    connection.Close();
                
                return result;
            }
        }

        public static void addData(Form1.allFields data, int param)
        {
            using (HanaCommand command = new HanaCommand() { Connection = connection })
            {
                connection.Open();
                
                data.createDate = (data.createDate != null) ? data.createDate.Replace(".", string.Empty) : null;
                data.instDate = (data.instDate != null) ? data.instDate.Replace(".", string.Empty) : null;
                data.shipingDate = (data.shipingDate != null) ? data.shipingDate.Replace(".", string.Empty) : null;
                data.snDate = (data.snDate != null) ? data.snDate.Replace(".", string.Empty) : null;

                data.instDate = (data.instDate == "") ? null : data.instDate ;
                data.snDate = (data.snDate == "") ? null : data.snDate ;
                data.insID = (data.insID == "") ? null : data.insID;

                string cmdAdd = "";
                if (param == 1)
                {
                    cmdAdd = string.Format(@"INSERT INTO ""BRANCHES_EURO"".""@ACC_PAINTS_IT"" (""DocEntry"",""LineId"",""U_Code"",""U_Name"",""U_Picture"",""U_SerialNumber"",""U_Articul"",""U_EAN"",""U_InstDate"",""U_LifeTime"",""U_drDownDate"",""U_Comment"",""U_Warning"",""U_Characteristics"",""U_Modification"",""U_insID"") VALUES ({0}, {1}, '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}',{15})", Int32.Parse(data.docEntry), Int32.Parse(data.lineId), data.code1, data.title, data.photo, data.serialNumber, data.articul, data.EAN, data.instDate, data.srokExpl, data.snDate, data.comment, data.warning, data.charact, data.modif, Int32.Parse(data.insID));


                  //  cmdAdd = string.Format(@"INSERT INTO ""BRANCHES_EURO"".""@ACC_PAINTS_IT"" (""DocEntry"",""LineId"",""U_Code"",""U_Name"",""U_Picture"",""U_SerialNumber"",""U_Articul"",""U_EAN"",""U_InstDate"",""U_LifeTime"",""U_drDownDate"",""U_Comment"",""U_Warning"",""U_Characteristics"",""U_Modification"",""U_insID"") VALUES (" + Int32.Parse(data.docEntry) + "," + Int32.Parse(data.lineId) + "," + data.code1 + "," + data.title + "," + data.photo + "," + data.serialNumber + "," + data.articul + "," + data.EAN + "," + data.instDate + "," + data.srokExpl + "," + data.snDate + "," + data.comment + "," + data.warning + "," + data.charact + "," + data.modif + "," + Int32.Parse(data.insID) + ")");
                    using (HanaCommand cmd = new HanaCommand() { CommandText = cmdAdd, Connection = connection })
                    {
                        cmd.ExecuteNonQuery();
                    }

                    //command.CommandText = string.Format(@"INSERT INTO ""BRANCHES_EURO"".""@ACC_PAINTS_IT"" (""DocEntry"",""LineId"",""U_Code"",""U_Name"",""U_Picture"",""U_SerialNumber"",""U_Articul"",""U_EAN"",""U_InstDate"",""U_LifeTime"",""U_drDownDate"",""U_Comment"",""U_Warning"",""U_Characteristics"",""U_Modification"",""U_insID"") VALUES ({0}, {1}, '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}',{15})", Int32.Parse(data.docEntry), Int32.Parse(data.lineId), data.code1, data.title, data.photo, data.serialNumber, data.articul, data.EAN, data.instDate, data.srokExpl, data.snDate, data.comment, data.warning, data.charact, data.modif, Int32.Parse(data.insID));
                    //command.CommandText = string.Format(@"insert into ""@ACC_PAINTS_IT"" (""DocEntry"",""LineId"",""U_Code"",""U_Name"",""U_InstDate"",""U_drDownDate"",""U_insID"") values ({0},{1},'{2}','{3}','{4}','{5}',{6})", Int32.Parse(data.docEntry), Int32.Parse(data.lineId), data.code1, data.title, data.instDate, data.snDate, Int32.Parse(data.insID));
                    //string cmdAdd = @"INSERT INTO ""BRANCHES_EURO"".""@ACC_PAINTS_IT"" (""DocEntry"",""LineId"",""U_Code"",""U_Name"",""U_InstDate"",""U_insID"") VALUES (" + Int32.Parse(data.docEntry) + "," + Int32.Parse(data.lineId) + "," + data.code1 + "," + data.title + "," + data.instDate + "," + Int32.Parse(data.insID) + ")";
                    
                    //command.CommandText = string.Format(@"INSERT INTO ""BRANCHES_EURO"".""@ACC_PAINTS_IT"" (""DocEntry"",""LineId"",""U_InstDate"",""U_drDownDate"",""U_insID"") VALUES ({0},{1},'{2}','{3}',{4})", Int32.Parse(data.docEntry), Int32.Parse(data.lineId), data.instDate, data.snDate, Int32.Parse(data.insID));
                    //command.ExecuteNonQuery();
                }
                else if (param == 2)
                {
                    cmdAdd = @"INSERT INTO ""BRANCHES_EURO"".""@ACC_PAINTS_ITEMS_2"" (""DocEntry"",""LineId"",""U_Code"",""U_TitlePaint"",""U_BatchNumber"",""U_Articul"",""U_EAN"",""U_ManufDate"",""U_ShelfLife"",""U_DeliveryDate"",""U_Comment"",""U_Warning"",""U_insID"") VALUES (" + Int32.Parse(data.docEntry) + "," + Int32.Parse(data.lineId) + "," + data.code1 + "," + data.title + "," + data.batchNumber + "," + data.serialNumber + "," + data.articul + "," + data.EAN + "," + data.createDate + "," + data.srokExpl + "," + data.shipingDate + "," + data.comment + "," + data.warning + "," + Int32.Parse(data.insID) + ")";
                    //command.CommandText = string.Format(@"INSERT INTO ""BRANCHES_EURO"".""@ACC_PAINTS_ITEMS_2"" (""DocEntry"",""LineId"",""U_Code"",""U_TitlePaint"",""U_BatchNumber"",""U_Articul"",""U_EAN"",""U_ManufDate"",""U_ShelfLife"",""U_DeliveryDate"",""U_Comment"",""U_Warning"",""U_insID"") VALUES ({0}, {1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',{12})", Int32.Parse(data.docEntry), Int32.Parse(data.lineId), data.code1, data.title, data.batchNumber, data.articul, data.EAN, data.createDate, data.srokExpl, data.shipingDate, data.comment,data.warning,Int32.Parse(data.insID));
                }

                connection.Close();
            }
        }

        public static void updateData(Form1.allFields data, int param)
        {
            using (HanaCommand command = new HanaCommand() { Connection = connection })
            {
                connection.Open();
                
                string cmdAdd = "";
                if (param == 1)
                {
                    using (HanaCommand cmd = new HanaCommand() { CommandText = cmdAdd, Connection = connection })
                    {
                        command.CommandText = @"UPDATE ""BRANCHES_EURO"".""@ACC_PAINTS_IT"" SET (";
                        command.CommandText += string.Format(@"""DocEntry""={0}", 1);//Int32.Parse(data.docEntry));
                        command.CommandText += string.Format(@"""LineId""={0}", 1);//Int32.Parse(data.lineId));
                        command.CommandText += string.Format(@"""U_Code""='{0}'", "001");//data.code1);
                        command.CommandText += string.Format(@"""U_Name""='{0}'", "Товар 1 [Batch]");//data.title);
                        command.CommandText += string.Format(@"where ""insID""={0}", 2);//Int32.Parse(data.insID));

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }
                    cmdAdd = @"UPDATE ""BRANCHES_EURO"".""@ACC_PAINTS_IT"" SET (""DocEntry"",""LineId"",""U_Code"",""U_Name"",""U_Picture"",""U_SerialNumber"",""U_Articul"",""U_EAN"",""U_InstDate"",""U_LifeTime"",""U_drDownDate"",""U_Comment"",""U_Warning"",""U_Characteristics"",""U_Modification"") VALUES (" + Int32.Parse(data.docEntry) + "," + Int32.Parse(data.lineId) + "," + data.code1 + "," + data.title + "," + data.photo + "," + data.serialNumber + "," + data.articul + "," + data.EAN + "," + data.instDate + "," + data.srokExpl + "," + data.snDate + "," + data.comment + "," + data.warning + "," + data.charact + "," + data.modif + ")";
                    //cmdAdd = @"UPDATE ""BRANCHES_EURO"".""@ACC_PAINTS_ITEMS_2"" SET ""LineId""=" + Int32.Parse(data.lineId) + "WHERE \"DocEntry\"=" + Int32.Parse(data.docEntry);
                    //cmdAdd = @"UPDATE ""BRANCHES_EURO"".""@ACC_PAINTS_ITEMS_2"" SET ""LineId""= ' WHERE \"DocEntry\"=" + Int32.Parse(data.docEntry);
                }
                else if (param == 2)
                {
                    cmdAdd = @"UPDATE ""BRANCHES_EURO"".""@ACC_PAINTS_ITEMS_2"" SET ""LineId""=" + Int32.Parse(data.lineId) + "WHERE \"U_insID\"=" + Int32.Parse(data.insID) ;
                }

                using (HanaCommand cmd = new HanaCommand() { CommandText = cmdAdd, Connection = connection })
                {
                    cmd.ExecuteNonQuery();
                }

                connection.Close();      
            }
        }

    }
}
