<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
 <xsl:template match="/">
    <html>
        <head></head>
        <body>
        <h2>Receta</h2>
        <xsl:for-each select="receta/">
        <h2><xsl:value-of select="titulo"></h2>
        </body>
    </html>