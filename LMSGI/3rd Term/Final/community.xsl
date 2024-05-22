<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <head>
                <title>Comunidades</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        background-color: #222;
                        color: #ddd;
                    }
                    h1 {
                        color: #FF5733; 
                    }
                    h2 {
                        color: #9B870C; 
                    }
                    h3 {
                        color: #D9BF77; 
                    }
                    p {
                        color: #ddd;
                    }
                    .habilidad, .item {
                        color: #FFD700; 
                    }
                    .habilidad_baja {
                        color: #808080
                    }
                    .persona {
                        border: 1px solid #666;
                        padding: 10px;
                        margin: 10px 0;
                        display: flex;
                        align-items: flex-start;
                        background-color: #333; 
                    }
                    .persona img {
                        margin-right: 20px;
                        width: 100px;
                        height: 100px;
                    }
                    .persona-info {
                        flex: 1;
                    }
                    table {
                        width: 100%;
                        border-collapse: collapse;
                    }
                    th, td {
                        border: 1px solid #666;
                        padding: 8px;
                        text-align: left;
                    }
                    th {
                        background-color: #444; /* Gris */
                    }
                    tr:first-child {
                        border-bottom: 2px solid #666; /* Borde gris */
                    }
                </style>
            </head>
            <body>
                <h1>Comunidades</h1>
                <xsl:for-each select="/comunidades/comunidad">
                    <div class="comunidad">
                        <h2>Comunidad: <xsl:value-of select="@nombre"/></h2>
                        <p>Cantidad de Habitantes: <xsl:value-of select="@cantidadHabitantes"/></p>
                        <xsl:for-each select="persona">
                            <div class="persona">
                                <img src="img/{img}" alt="{nombre}"/>
                                <div class="persona-info">
                                    <h3>Nombre: <xsl:value-of select="nombre"/></h3>
                                    <p>Edad: <xsl:value-of select="edad"/></p>
                                    <h4>Habilidades</h4>
                                    <table>
                                        <tr>
                                            <th>Cardio</th>
                                            <th>Ingenio</th>
                                            <th>Pelea</th>
                                            <th>Disparo</th>
                                        </tr>
                                        <tr>
                                            <td>
                                                <xsl:if test="habilidades/cardio &lt; 4">
                                                    <span class="habilidad_baja"><xsl:value-of select="habilidades/cardio"/></span>
                                                </xsl:if>
                                                <xsl:if test="habilidades/cardio &gt;= 4">
                                                    <span class="habilidad"><xsl:value-of select="habilidades/cardio"/></span>
                                                </xsl:if>
                                            </td>
                                            <td>
                                                <xsl:if test="habilidades/ingenio &lt; 4">
                                                    <span class="habilidad_baja"><xsl:value-of select="habilidades/ingenio"/></span>
                                                </xsl:if>
                                                <xsl:if test="habilidades/ingenio &gt;= 4">
                                                    <span class="habilidad"><xsl:value-of select="habilidades/ingenio"/></span>
                                                </xsl:if>
                                            </td>
                                            <td>
                                                <xsl:if test="habilidades/pelea &lt; 4">
                                                    <span class="habilidad_baja"><xsl:value-of select="habilidades/pelea"/></span>
                                                </xsl:if>
                                                <xsl:if test="habilidades/pelea &gt;= 4">
                                                    <span class="habilidad"><xsl:value-of select="habilidades/pelea"/></span>
                                                </xsl:if>
                                            </td>
                                            <td>
                                                <xsl:if test="habilidades/disparo &lt; 4">
                                                    <span class="habilidad_baja"><xsl:value-of select="habilidades/disparo"/></span>
                                                </xsl:if>
                                                <xsl:if test="habilidades/disparo &gt;= 4">
                                                    <span class="habilidad"><xsl:value-of select="habilidades/disparo"/></span>
                                                </xsl:if>
                                            </td>
                                        </tr>
                                    </table>
                                    <h4>Inventario</h4>
                                    <table>
                                        <tr>
                                            <th>Nombre</th>
                                            <th>Descripción</th>
                                            <th>Cantidad</th>
                                            <th>Tipo</th>
                                        </tr>
                                        <xsl:for-each select="inventario/item">
                                            <tr>
                                                <td class="item"><xsl:value-of select="nombre"/></td>
                                                <td class="item"><xsl:value-of select="descripcion"/></td>
                                                <td class="item"><xsl:value-of select="cantidad"/></td>
                                                <td class="item"><xsl:value-of select="@tipo"/></td>
                                            </tr>
                                        </xsl:for-each>
                                    </table>
                                </div>
                            </div>
                        </xsl:for-each>
                    </div>
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>