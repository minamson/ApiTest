using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Service
{
    public class SchemaService
    {
        public static string schema_sql = @"
    
    SELECT  
         ROW_NUMBER() OVER(ORDER BY AA.TABLE_NAME, AA.COLUMN_ID) AS ID,     
          
         AA.TABLE_NAME        AS TABLE_NAME,
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
        
        -- AA.DATA_LENGTH       AS DATA_LENGTH,
        -- AA.NULLABLE          AS NULLABLE,
         decode(aA.nullable, 'Y', 'NULL', 'NOT NULL') AS ISNULL,-- NULL 여부
         AA.DATA_DEFAULT      AS DATA_DEFAULT,
         CC.PK                AS PK,
         CC.FK                AS FK,
         CC.UK                AS UQ
         
    FROM ALL_TAB_COLUMNS AA,
         ALL_COL_COMMENTS BB,
         (SELECT A.OWNER,
                 A.TABLE_NAME,
                 A.CONSTRAINT_TYPE,
                 COLUMN_NAME,
                 POSITION,
                 CASE WHEN A.CONSTRAINT_TYPE = 'P' THEN 'Y' END AS PK,
                 CASE WHEN A.CONSTRAINT_TYPE = 'R' THEN 'Y' END AS FK,
                 CASE WHEN A.CONSTRAINT_TYPE = 'U' THEN 'Y' END AS UK
            FROM ALL_CONSTRAINTS A, ALL_CONS_COLUMNS B
           WHERE   A.OWNER = b.OWNER
                 AND A.TABLE_NAME = B.TABLE_NAME
                  AND A.CONSTRAINT_NAME = B.CONSTRAINT_NAME
                 AND A.CONSTRAINT_TYPE IN ('P', 'R','U')) CC
   WHERE 
         AA.OWNER like 'MINAM'
         AND AA.TABLE_NAME LIKE '%'
         AND AA.OWNER = BB.OWNER
         AND AA.TABLE_NAME = BB.TABLE_NAME
         AND AA.COLUMN_NAME = BB.COLUMN_NAME
         AND AA.OWNER = CC.OWNER(+)
         AND AA.TABLE_NAME = CC.TABLE_NAME(+)
         AND AA.COLUMN_NAME = CC.COLUMN_NAME(+)
         AND AA.TABLE_NAME != 'SCHEM_INFO'
         
ORDER BY TABLE_NAME, COLUMN_ID, COLUMN_NAME

 ";


    }
}
