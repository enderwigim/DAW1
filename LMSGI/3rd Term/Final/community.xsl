<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:output method="html" indent="yes"/>
    <xsl:template match="/comunidades">
        <html>
            <head>
                <title>Comunidades</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        color: #333333;
                    }
                    .comunidad {
                        margin-bottom: 20px;
                        padding: 10px;
                        border: 1px solid #cccccc;
                        background-color: #ffffff;
                    }
                    .persona {
                        display: flex;
                        justify-content: space-between;
                        align-items: flex-start;
                        margin-bottom: 10px;
                        padding: 10px;
                        border: 1px solid #cccccc;
                        background-color: #e9f7fd;
                    }
                    .persona-details {
                        flex: 1;
                        margin-right: 20px;
                        justify-content: center;
                    }
                    .persona img {
                        max-width: 150px;
                        height: auto;
                        border: 1px solid #cccccc;
                        padding: 5px;
                        background-color: #ffffff;
                    }
                    .inventario {
                        margin-top: 10px;
                        padding: 10px;
                        border-top: 1px solid #cccccc;
                        background-color: #ffffff;
                    }
                    table {
                        width: 100%;
                        border-collapse: collapse;
                    }
                    th {
                        padding: 5px;
                        text-align: left;
                        border: 1px solid #cccccc;
                        background-color: #d9edf7;
                    }
                    td {
                        padding: 5px;
                        text-align: left;
                        border: 1px solid #cccccc;
                    }
                    h1, h2, h3, h4 {
                        color: #2c3e50;
                    }
                    
                </style>
            </head>
            <body>
                <h1>Comunidades</h1>
                <xsl:for-each select="comunidad">
                    <div class="comunidad">
                        <h2><xsl:value-of select="@nombre"/> - <xsl:value-of select="@cantidadHabitantes"/> habitantes</h2>
                        <xsl:for-each select="persona">
                            <div class="persona">
                                <div class="persona-details">
                                    <h3><xsl:value-of select="nombre"/> (Edad: <xsl:value-of select="edad"/>)</h3>
                                    <h4>Habilidades</h4>
                                    <ul>
                                        <li>Cardio: <xsl:value-of select="habilidades/cardio"/></li>
                                        <li>Ingenio: <xsl:value-of select="habilidades/ingenio"/></li>
                                        <li>Pelea: <xsl:value-of select="habilidades/pelea"/></li>
                                        <li>Disparo: <xsl:value-of select="habilidades/disparo"/></li>
                                    </ul>
                                    <div class="inventario">
                                        <h4>Inventario</h4>
                                        <table>
                                            <tr>
                                                <th>Nombre</th>
                                                <th>Tipo</th>
                                                <th>Descripción</th>
                                                <th>Cantidad</th>
                                            </tr>
                                            <xsl:for-each select="inventario/item">
                                                <tr>
                                                    <td><xsl:value-of select="nombre"/></td>
                                                    <td><xsl:value-of select="@tipo"/></td>
                                                    <td><xsl:value-of select="descripcion"/></td>
                                                    <td><xsl:value-of select="cantidad"/></td>
                                                </tr>
                                            </xsl:for-each>
                                        </table>
                                    </div>
                                </div>
                                <img src="img/{img}" alt="Imagen de {nombre}"/>
                            </div>
                        </xsl:for-each>
                    </div>
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>