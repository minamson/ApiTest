

SELECT
     ROW_NUMBER() OVER(ORDER BY A.TABLE_NAME, A.COLUMN_ID) AS ID,
     --A.OWNER           AS OWNER_SCHEM,    
     AA.TABLE_NAME        AS TABLE_NAME,
     NVL(TC.COMMENTS,'')  AS TABLE_COMMENT,
--     DECODE(C.TABLE_TYPE,'TABLE','T','V') AS KIND,
     C.TABLE_TYPE     AS KIND,
     A.COLUMN_ID      AS COLUMN_ID,
     A.COLUMN_NAME    AS COLUMN_NAME,
     B.COMMENTS       AS COMMENTS,
     A.DATA_TYPE ||
      (CASE WHEN DATA_TYPE LIKE '%CHAR%'THEN
                '(' || DATA_LENGTH || ')'
            WHEN DATA_TYPE = 'NUMBER' AND DATA_PRECISION > 0 AND DATA_SCALE > 0 THEN
                '(' || DATA_PRECISION || ',' || DATA_SCALE || ')'
            WHEN DATA_TYPE = 'NUMBER' AND DATA_PRECISION > 0 THEN
                '(' || DATA_PRECISION || ')'
       END)             AS DATA_TYPE,
       
     DECODE(NULLABLE, 'N', 'NOT NULL','NULL') AS NULLABLE,
     A.DATA_DEFAULT       AS DATA_DEFAULT,
     CC.PK                AS PK,
     CC.FK                AS FK,
     CC.UK                AS UQ
     
  FROM ALL_TAB_COLUMNS  A,
     ALL_COL_COMMENTS B,
     ALL_TAB_COMMENTS C,
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
                 
 WHERE '1' = '1'
   AND A.OWNER LIKE 'MINAM'
   AND A.TABLE_NAME  LIKE '%'
   AND A.OWNER       = B.OWNER
   AND A.OWNER       = C.OWNER
   
   AND A.TABLE_NAME  = B.TABLE_NAME(+)
   AND A.TABLE_NAME  = C.TABLE_NAME(+)
   
   AND A.COLUMN_NAME = B.COLUMN_NAME
   
    AND A.OWNER = CC.OWNER(+)
    AND A.TABLE_NAME = CC.TABLE_NAME(+)
    AND A.COLUMN_NAME = CC.COLUMN_NAME(+)
         
    AND NVL(A.TABLE_NAME,'NONE')  LIKE '%%'
    AND NVL(A.COLUMN_NAME,'NONE') LIKE '%%'
    AND NVL(B.COMMENTS,'NONE') LIKE '%'||''||'%'
    
    --AND A.TABLE_NAME != 'SCHEM_INFO'

 ORDER BY A.OWNER,A.TABLE_NAME ,  A.COLUMN_ID, A.COLUMN_NAME
 
 
 