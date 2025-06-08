namespace DataAccess
{

    public class ORACLE
    {
        public static string OraceDefaultSchema = "MINAM";

        public static string OracleConnectString = @"Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)
                                                    (HOST = localhost)(PORT = 1521))
                                                    (CONNECT_DATA = (SERVICE_NAME = COMPANYDB))); 
                                                    User ID=MINAM; Password=thsalska;";

        public static string OracleConnection(string host, int port, string sid, string username, string password)
        {

            return string.Format( @"Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)
                                                    (HOST = {0})(PORT = {1}))
                                                    (CONNECT_DATA = (SERVICE_NAME = {2}))); 
                                                    User ID={3}; Password={4};", host, port.ToString(),sid, username, password);
        }

        public static string SchemInfo = @" 

        SELECT  
         ROW_NUMBER() OVER(ORDER BY AA.TABLE_NAME, AA.COLUMN_ID) AS ID,    
         AA.TABLE_NAME ||'['||NVL(TC.COMMENTS,'')||']'        AS TABLE_NAME,
--     DECODE(C.TABLE_TYPE,'TABLE','T','V') AS KIND,
         TC.TABLE_TYPE       AS KIND,
         AA.COLUMN_ID         AS COLUMN_ID,
         AA.COLUMN_NAME       AS COLUMN_NAME,
         BB.COMMENTS          AS COMMENTS,
         AA.DATA_TYPE || 
        (case when AA.data_type like '%CHAR%' then '(' || AA.data_length || ')'
              when AA.data_type = 'NUMBER' AND AA.data_precision > 0 AND AA.data_scale > 0
                then '(' || AA.data_precision || ',' || AA.data_scale || ')'
              when AA.data_type = 'NUMBER' AND AA.data_precision > 0 
                then '(' || AA.data_precision ||')'
        end )                 AS DATA_TYPE,       -- 자릿수 표현한 데이터 유형
        
         decode(AA.nullable, 'Y', 'NULL', 'NOT NULL') AS ISNULL,-- NULL 여부
         AA.DATA_DEFAULT      AS DATA_DEFAULT,
         CC.PK                AS PK,
         CC.FK                AS FK,
         CC.UQ                AS UQ
         
    FROM ALL_TAB_COLUMNS  AA,
         ALL_COL_COMMENTS BB,
         ALL_TAB_COMMENTS TC,
         (SELECT A.OWNER,
                 A.TABLE_NAME,
                 A.CONSTRAINT_TYPE,
                 COLUMN_NAME,
                 POSITION,
                 CASE WHEN A.CONSTRAINT_TYPE = 'P' THEN 'Y' END AS PK,
                 CASE WHEN A.CONSTRAINT_TYPE = 'R' THEN 'Y' END AS FK,
                 CASE WHEN A.CONSTRAINT_TYPE = 'U' THEN 'Y' END AS UQ
            FROM ALL_CONSTRAINTS A, ALL_CONS_COLUMNS B
           WHERE   A.OWNER = B.OWNER
                 AND A.TABLE_NAME = B.TABLE_NAME
                  AND A.CONSTRAINT_NAME = B.CONSTRAINT_NAME
                 AND A.CONSTRAINT_TYPE IN ('P', 'R','U')) CC
   WHERE 
         AA.OWNER LIKE 'MINAM'
         AND AA.OWNER = BB.OWNER
         AND AA.TABLE_NAME = BB.TABLE_NAME
         AND AA.COLUMN_NAME = BB.COLUMN_NAME
         
         AND AA.OWNER = TC.OWNER(+)
         AND AA.TABLE_NAME = TC.TABLE_NAME(+)
         
         AND AA.OWNER = CC.OWNER(+)
         AND AA.TABLE_NAME = CC.TABLE_NAME(+)
         AND AA.COLUMN_NAME = CC.COLUMN_NAME(+)
         
        -- AND NVL(AA.TABLE_NAME,'NONE')  LIKE '%'||':PTNAME%'||'%'
        -- AND NVL(TC.COMMENTS,'NONE') LIKE '%'||':PTCOMMENT'||'%'
         
        -- AND  NVL(AA.COLUMN_NAME,'NONE') LIKE '%'||':PCNAME%'||'%'
        -- AND  NVL(BB.COMMENTS,'NONE') LIKE '%'||':PCCOMMENT'||'%'
         
        -- AND AA.TABLE_NAME != 'SCHEM_INFO' 

ORDER BY TABLE_NAME, COLUMN_ID, COLUMN_NAME
 
";

    }
}
