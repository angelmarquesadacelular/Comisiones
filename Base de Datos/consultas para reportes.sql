use comisionesatc;

SELECT numero_id, MAX(montoA),Sum(comision)
FROM comisionessemanales
group by numero_id;

SELECT tipopago,SUM(comision) FROM volumenventa GROUP BY tipopago;

SELECT vv.lada as lada,vv.tipopago as tipo,SUM(vv.comision) as comision
FROM volumenventa vv,tipo_pago tp
WHERE vv.tipopago=tp.descripcion
AND tp.descripcion='EFECTIVO'
GROUP BY vv.lada
ORDER BY comision DESC;

SELECT vv.lada as lada,vv.tipopago as tipo,SUM(vv.comision) as comision
FROM volumenventa vv,tipo_pago tp
WHERE vv.tipopago=tp.descripcion
AND tp.descripcion='NOTA CR'
GROUP BY vv.lada
ORDER BY comision DESC;


SELECT tipopago,SUM(comision) AS comision
FROM volumenventa
WHERE periodo_id='1'
GROUP BY tipopago;

SELECT puntoventa, SUM(comision) AS comision
FROM volumenventa
WHERE periodo_id=2
GROUP BY puntoventa
ORDER BY comision desc;

SELECT tipo, COUNT(*) as total
FROM comisionessemanales
WHERE periodo_id=1
GROUP BY tipo;

SELECT puntoventa, SUM(comision) as comision
FROM comisionessemanales
WHERE periodo_id=1
GROUP BY puntoventa;







