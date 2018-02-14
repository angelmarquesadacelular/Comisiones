use comisionesatc;

SELECT numero_id, MAX(montoA),Sum(comision)
FROM comisionessemanales
group by numero_id;