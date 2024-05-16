<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
 <xsl:template match="/">
    <html>
        <head>
            <style>
                .container {
                    display: flex;
                    flex-direction: column;
                    justify-content: center;
                    align-items: center;
                    text-align: left;
                    min-height: 100vh;
                }
                h1 {
                    text-align: center;
                    padding-left: 25%;
                    padding-right: 25%;
                    background-color: black;
                    color: #fff
                }
                h2 {
                    color: brown;
                }
                th, td {
                        padding: 8px;
                        text-align: left;
                    }
                
                
                
            </style>
        </head>
        <body>
        <div class="container">
            <h1>Receta</h1>
            <div class="receta">
                <xsl:for-each select="/receta">
                    <h2><xsl:value-of select="titulo"/></h2>
                    <!-- <xsl:text> es una etiqueta qeu nos permite agregar texto -->
                    <p>Tiempo de elaboraboracion: <xsl:value-of select="tiempo_elaboracion"/> <xsl:text> </xsl:text><xsl:value-of select="tiempo_elaboracion/@t_medida"/>
                    <br></br>
                    Origen: <xsl:value-of select="cocina"/>
                    <br></br>
                    Especialidad: <xsl:value-of select="especialidad"/>
                    </p>
                    <h3>Ingredientes (<xsl:value-of select="ingredientes/@comensales"/> Comensales)</h3>
                    <table>
                        <tr class="firtTR">
                            <td>Nombre</td>
                            <td>Cantidad</td>
                            <td>Medida</td>
                            <td>Categoria</td>
                        </tr>
                        <xsl:for-each select="ingredientes/ingrediente">
                        <tr>
                            <td><xsl:value-of select="nombre"/></td>
                            <td><xsl:value-of select="cantidad"/></td>
                            <td><xsl:value-of select="medida"/></td>
                            <td><xsl:value-of select="./@categoria"/></td>
                        </tr>
                        </xsl:for-each>
                    </table>
                    <h3>Proceso</h3>
                        <ol>
                            <xsl:for-each select="procedimiento/paso">
                                <li><xsl:value-of select="."/></li>
                            </xsl:for-each>
                        </ol>
                    
                    
                </xsl:for-each>
            </div>
        </div>
        </body>
    </html>
 </xsl:template>
</xsl:stylesheet>