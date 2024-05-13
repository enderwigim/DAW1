<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
 <xsl:template match="/">
 <html>
 <head>
 <title>Ejemplo</title>
 <style>
 .tabla { display: table; border: 2px solid black; }
 .fila { display: table-row; }
 .filaEncapçat { display: table-row; background-color:#9acd32;
 font-weigth: bold; }
 .celda { display: table-cell; border: 1px solid black; padding:3px; }
 </style>
 </head>
 <body>
 <h2>Expedient acadèmic</h2>
 <h3> Alumne: <xsl:value-of select="expedient/@alumno"></xsl:value-of> </h3>
 <div class="taula">
 <div class="filaEncapçat">
 <div class="celda">Asignatura</div>
 <div class="celda">Nota</div>
 </div>
 <xsl:for-each select="expedient/assignatura">
 <div class="fila">
 <div class="celda">
 <xsl:value-of select="nom"/>
 </div>
 <div class="celda">
 <xsl:value-of select="nota"/>
 </div>
 </div>
 </xsl:for-each>
 </div>
 </body>
 </html>
 </xsl:template>
</xsl:stylesheet>