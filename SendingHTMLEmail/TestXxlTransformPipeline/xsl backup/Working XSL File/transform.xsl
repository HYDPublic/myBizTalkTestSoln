<?xml version="1.0"?>
<xsl:stylesheet version="1.0"  xmlns:Piksel="http://Piksel.MediaServicesFramework.Workflow.Schemas.EntryTest"  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <meta http-equiv="Content-Type" content="text/html; charset=windows-1252"/>
        <title>My Title</title>
        <style></style>
      </head>
      <body bgcolor="#cdcdcd">
        <table border="20" cellpadding="0" cellspacing="0" style="border-collapse: collapse" bordercolor="#444444" width="100%" id="AutoNumber1" height="336">
          <tr>
            <td width="50%" bgcolor="#cdcdcd" height="106">
              <i>
                <font size="7" face="Arial Black">Piksel Inc</font>
              </i>
              <font face="Arial"></font>
              <i>
                <b>
                  <font face="Arial Black">Powered By</font>
                  <font face="Arial Black"></font>
                  <font size="5" face="Arial Black">BizTalk Server 2010</font>                  
                </b>
              </i>
            </td>
          </tr>
          <tr>
            <td width="50%" height="223" bgcolor="#cdcdcd">
              <font face="Arial">
                Dear
                <!--<b><xsl:value-of select="//Name"/></b>!-->
                <p>Thank you for shopping with Northwind Inc. We would like to confirm that your order has been received.</p>
                <!--<p>On <xsl:value-of select="//Date"/> you have ordered:</p>-->
                <p>

                  Your affiliate value is : <b>
                    <xsl:value-of select="Piksel:ContentRepository/Piksel:MediaItem/Piksel:AffiliateMediaItems/Piksel:AffiliateMediaItem/@affiliateDomain"/>
                  </b>
                </p>
                <p>
                  Your SupplierReference is: <b>
                    <xsl:value-of select="Piksel:ContentRepository/Piksel:MediaItem/@supplierReference"/>
                  </b>
                </p>

                                
                <p>

                  <xsl:variable name="Success" select="Piksel:ContentRepository/Piksel:IsSuccess"/>
                  <xsl:choose>                    
                    <xsl:when test="$Success ='true'">
                      Parent processing is successfully completed for Media Item Reference: : <b>
                        <xsl:value-of select="Piksel:ContentRepository/Piksel:MediaItem/@supplierReference"/>
                      </b>
                    </xsl:when>
                    
                    <xsl:otherwise>
                      The parent process failed to complete for the media Item Reference: <b>
                        <xsl:value-of select="Piksel:ContentRepository/Piksel:MediaItem/@supplierReference"/>
                      </b>
                    </xsl:otherwise>
                  </xsl:choose>

                </p>
              </font>
            </td>
          </tr>
          <tr>
            <td width="50%" height="46" bgcolor="#cdcdcd">
              <p align="center">
                <font face="Arial">
                  To check the status of your order go to :
                  <a href="http://www.piksel.com/">Piksel</a>
                </font>
              </p>
            </td>
          </tr>
          <tr>
            <td width="50%" height="19" bgcolor="#cdcdcd">
              <p align="center">
                <font face="Arial">
                  <i>
                    <b>
                      <font size="2">Thank You For Ordering From Piksel Inc</font>
                    </b>
                  </i>
                </font>
              </p>
            </td>
          </tr>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
