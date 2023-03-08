namespace Outbound_PO_EDI_Pickup.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.cXML.cXML", typeof(global::EdiSchemas.cXML.cXML))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.X12.X12_00401_860", typeof(global::EdiSchemas.X12.X12_00401_860))]
    public sealed class PO_860_Map : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/cXML"" />
  </xsl:template>
  <xsl:template match=""/cXML"">
    <xsl:variable name=""var:v151"" select=""count(/cXML/Request/OrderRequest/ItemOut/ItemDetail)"" />
    <ns0:X12_00401_860>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimRight(&quot;860&quot;)"" />
          <ST>
            <ST01>
              <xsl:value-of select=""$var:v1"" />
            </ST01>
            <ST02>
              <xsl:value-of select=""OrderRequestHeader/@orderID"" />
            </ST02>
          </ST>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <ns0:BCH>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(@name) , &quot;orderType&quot;)"" />
              <xsl:if test=""string($var:v2)='true'"">
                <xsl:variable name=""var:v3"" select=""./text()"" />
                <BCH01>
                  <xsl:value-of select=""$var:v3"" />
                </BCH01>
              </xsl:if>
            </xsl:for-each>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v4"" select=""string(@name)"" />
              <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq($var:v4 , &quot;shipType&quot;)"" />
              <xsl:if test=""string($var:v5)='true'"">
                <xsl:variable name=""var:v6"" select=""./text()"" />
                <BCH02>
                  <xsl:value-of select=""$var:v6"" />
                </BCH02>
              </xsl:if>
            </xsl:for-each>
            <BCH03>
              <xsl:value-of select=""OrderRequestHeader/@orderID"" />
            </BCH03>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v7"" select=""string(@name)"" />
              <xsl:variable name=""var:v8"" select=""userCSharp:LogicalEq($var:v7 , &quot;sequence&quot;)"" />
              <xsl:if test=""string($var:v8)='true'"">
                <xsl:variable name=""var:v9"" select=""./text()"" />
                <BCH05>
                  <xsl:value-of select=""$var:v9"" />
                </BCH05>
              </xsl:if>
            </xsl:for-each>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v10"" select=""string(@name)"" />
              <xsl:variable name=""var:v11"" select=""userCSharp:LogicalEq($var:v10 , &quot;changeDate&quot;)"" />
              <xsl:if test=""string($var:v11)='true'"">
                <xsl:variable name=""var:v12"" select=""./text()"" />
                <BCH06>
                  <xsl:value-of select=""$var:v12"" />
                </BCH06>
              </xsl:if>
            </xsl:for-each>
            <BCH10>
              <xsl:value-of select=""OrderRequestHeader/@orderDate"" />
            </BCH10>
          </ns0:BCH>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:variable name=""var:v13"" select=""userCSharp:StringTrimRight(&quot;CO&quot;)"" />
          <ns0:REF>
            <REF01>
              <xsl:value-of select=""$var:v13"" />
            </REF01>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v14"" select=""string(@name)"" />
              <xsl:variable name=""var:v15"" select=""userCSharp:LogicalEq($var:v14 , &quot;customerPurchaseOrder&quot;)"" />
              <xsl:if test=""string($var:v15)='true'"">
                <xsl:variable name=""var:v16"" select=""./text()"" />
                <REF02>
                  <xsl:value-of select=""$var:v16"" />
                </REF02>
              </xsl:if>
            </xsl:for-each>
          </ns0:REF>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:for-each select=""OrderRequestHeader/Contact"">
            <xsl:for-each select=""Phone"">
              <xsl:variable name=""var:v17"" select=""userCSharp:StringTrimRight(&quot;BD&quot;)"" />
              <xsl:variable name=""var:v18"" select=""userCSharp:LogicalEq(string(../@role) , &quot;purchasingAgent&quot;)"" />
              <xsl:variable name=""var:v20"" select=""userCSharp:StringTrimRight(&quot;TE&quot;)"" />
              <xsl:variable name=""var:v21"" select=""string(../@role)"" />
              <xsl:variable name=""var:v22"" select=""userCSharp:LogicalEq($var:v21 , &quot;purchasingAgent&quot;)"" />
              <xsl:variable name=""var:v27"" select=""userCSharp:StringTrimRight(&quot;EM&quot;)"" />
              <ns0:PER>
                <PER01>
                  <xsl:value-of select=""$var:v17"" />
                </PER01>
                <xsl:if test=""string($var:v18)='true'"">
                  <xsl:variable name=""var:v19"" select=""../Name/text()"" />
                  <PER02>
                    <xsl:value-of select=""$var:v19"" />
                  </PER02>
                </xsl:if>
                <PER03>
                  <xsl:value-of select=""$var:v20"" />
                </PER03>
                <xsl:if test=""string($var:v22)='true'"">
                  <xsl:variable name=""var:v23"" select=""TelephoneNumber/AreaOrCityCode/text()"" />
                  <xsl:variable name=""var:v24"" select=""userCSharp:StringTrimRight(&quot;-&quot;)"" />
                  <xsl:if test=""string($var:v22)='true'"">
                    <xsl:variable name=""var:v25"" select=""TelephoneNumber/Number/text()"" />
                    <xsl:variable name=""var:v26"" select=""userCSharp:StringConcat(string($var:v23) , string($var:v24) , string($var:v25))"" />
                    <PER04>
                      <xsl:value-of select=""$var:v26"" />
                    </PER04>
                  </xsl:if>
                </xsl:if>
                <PER05>
                  <xsl:value-of select=""$var:v27"" />
                </PER05>
                <xsl:for-each select=""../Email"">
                  <xsl:variable name=""var:v28"" select=""string(../@role)"" />
                  <xsl:variable name=""var:v29"" select=""userCSharp:LogicalEq($var:v28 , &quot;purchasingAgent&quot;)"" />
                  <xsl:if test=""string($var:v29)='true'"">
                    <xsl:variable name=""var:v30"" select=""./text()"" />
                    <PER06>
                      <xsl:value-of select=""$var:v30"" />
                    </PER06>
                  </xsl:if>
                </xsl:for-each>
              </ns0:PER>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <ns0:ITD>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v31"" select=""string(@name)"" />
              <xsl:variable name=""var:v32"" select=""userCSharp:LogicalEq($var:v31 , &quot;Payment_Terms&quot;)"" />
              <xsl:if test=""string($var:v32)='true'"">
                <xsl:variable name=""var:v33"" select=""./text()"" />
                <ITD12>
                  <xsl:value-of select=""$var:v33"" />
                </ITD12>
              </xsl:if>
            </xsl:for-each>
          </ns0:ITD>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:variable name=""var:v34"" select=""userCSharp:StringTrimRight(&quot;002&quot;)"" />
          <ns0:DTM>
            <DTM01>
              <xsl:value-of select=""$var:v34"" />
            </DTM01>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v35"" select=""string(@name)"" />
              <xsl:variable name=""var:v36"" select=""userCSharp:LogicalEq($var:v35 , &quot;requestedDeliveryDate&quot;)"" />
              <xsl:if test=""string($var:v36)='true'"">
                <xsl:variable name=""var:v37"" select=""./text()"" />
                <DTM03>
                  <xsl:value-of select=""$var:v37"" />
                </DTM03>
              </xsl:if>
            </xsl:for-each>
          </ns0:DTM>
        </xsl:for-each>
      </xsl:for-each>
      <ns0:N9Loop1>
        <xsl:for-each select=""Request"">
          <xsl:for-each select=""OrderRequest"">
            <xsl:variable name=""var:v38"" select=""userCSharp:StringSize(string(OrderRequestHeader/Comments/text()))"" />
            <xsl:variable name=""var:v39"" select=""userCSharp:LogicalGt(string($var:v38) , &quot;0&quot;)"" />
            <xsl:if test=""$var:v39"">
              <ns0:N9>
                <xsl:for-each select=""OrderRequestHeader/Comments"">
                  <xsl:variable name=""var:v40"" select=""userCSharp:StringSize(string(./text()))"" />
                  <xsl:variable name=""var:v41"" select=""userCSharp:LogicalGt(string($var:v40) , &quot;0&quot;)"" />
                  <xsl:if test=""string($var:v41)='true'"">
                    <xsl:variable name=""var:v42"" select=""userCSharp:StringTrimRight(&quot;L1&quot;)"" />
                    <N901>
                      <xsl:value-of select=""$var:v42"" />
                    </N901>
                  </xsl:if>
                </xsl:for-each>
                <xsl:for-each select=""OrderRequestHeader/Comments"">
                  <xsl:variable name=""var:v43"" select=""string(./text())"" />
                  <xsl:variable name=""var:v44"" select=""userCSharp:StringSize($var:v43)"" />
                  <xsl:variable name=""var:v45"" select=""userCSharp:LogicalGt(string($var:v44) , &quot;0&quot;)"" />
                  <xsl:if test=""string($var:v45)='true'"">
                    <xsl:variable name=""var:v46"" select=""userCSharp:StringTrimRight(&quot;GEN&quot;)"" />
                    <N902>
                      <xsl:value-of select=""$var:v46"" />
                    </N902>
                  </xsl:if>
                </xsl:for-each>
              </ns0:N9>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""Request"">
          <xsl:for-each select=""OrderRequest"">
            <xsl:variable name=""var:v47"" select=""string(OrderRequestHeader/Comments/text())"" />
            <xsl:variable name=""var:v48"" select=""userCSharp:StringSize($var:v47)"" />
            <xsl:variable name=""var:v49"" select=""userCSharp:LogicalGt(string($var:v48) , &quot;0&quot;)"" />
            <xsl:if test=""$var:v49"">
              <ns0:MSG>
                <xsl:for-each select=""OrderRequestHeader/Comments"">
                  <xsl:variable name=""var:v50"" select=""string(./text())"" />
                  <xsl:variable name=""var:v51"" select=""userCSharp:StringSize($var:v50)"" />
                  <xsl:variable name=""var:v52"" select=""userCSharp:LogicalGt(string($var:v51) , &quot;0&quot;)"" />
                  <xsl:if test=""string($var:v52)='true'"">
                    <xsl:variable name=""var:v53"" select=""./text()"" />
                    <MSG01>
                      <xsl:value-of select=""$var:v53"" />
                    </MSG01>
                  </xsl:if>
                </xsl:for-each>
              </ns0:MSG>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:N9Loop1>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:for-each select=""OrderRequestHeader/ShipTo"">
            <xsl:variable name=""var:v54"" select=""userCSharp:StringTrimRight(&quot;ST&quot;)"" />
            <xsl:variable name=""var:v55"" select=""userCSharp:StringConcat(string(Address/Name/text()))"" />
            <xsl:variable name=""var:v56"" select=""userCSharp:StringTrimRight(&quot;92&quot;)"" />
            <xsl:variable name=""var:v57"" select=""userCSharp:StringConcat(string(Address/@addressID))"" />
            <xsl:variable name=""var:v58"" select=""Address/PostalAddress/Street[1]/text()"" />
            <xsl:variable name=""var:v59"" select=""Address/PostalAddress/Street[2]/text()"" />
            <xsl:variable name=""var:v60"" select=""userCSharp:StringConcat(string(Address/PostalAddress/City/text()))"" />
            <xsl:variable name=""var:v61"" select=""userCSharp:StringConcat(string(Address/PostalAddress/State/text()))"" />
            <xsl:variable name=""var:v62"" select=""userCSharp:StringConcat(string(Address/PostalAddress/PostalCode/text()))"" />
            <xsl:variable name=""var:v63"" select=""userCSharp:StringConcat(string(Address/PostalAddress/Country/@isoCountryCode))"" />
            <xsl:variable name=""var:v64"" select=""userCSharp:StringTrimRight(&quot;BT&quot;)"" />
            <xsl:variable name=""var:v65"" select=""userCSharp:StringConcat(string(../BillTo/Address/Name/text()))"" />
            <xsl:variable name=""var:v66"" select=""userCSharp:StringConcat(string(../BillTo/Address/@addressID))"" />
            <xsl:variable name=""var:v67"" select=""../BillTo/Address/PostalAddress/Street[1]/text()"" />
            <xsl:variable name=""var:v68"" select=""../BillTo/Address/PostalAddress/Street[2]/text()"" />
            <xsl:variable name=""var:v69"" select=""userCSharp:StringConcat(string(../BillTo/Address/PostalAddress/City/text()))"" />
            <xsl:variable name=""var:v70"" select=""userCSharp:StringConcat(string(../BillTo/Address/PostalAddress/State/text()))"" />
            <xsl:variable name=""var:v71"" select=""userCSharp:StringConcat(string(../BillTo/Address/PostalAddress/PostalCode/text()))"" />
            <xsl:variable name=""var:v72"" select=""userCSharp:StringConcat(string(../BillTo/Address/PostalAddress/Country/@isoCountryCode))"" />
            <xsl:variable name=""var:v73"" select=""$var:v54"" />
            <xsl:variable name=""var:v74"" select=""string(Address/Name/text())"" />
            <xsl:variable name=""var:v75"" select=""userCSharp:StringConcat($var:v74)"" />
            <xsl:variable name=""var:v76"" select=""string(Address/@addressID)"" />
            <xsl:variable name=""var:v77"" select=""userCSharp:StringConcat($var:v76)"" />
            <xsl:variable name=""var:v78"" select=""string(Address/PostalAddress/City/text())"" />
            <xsl:variable name=""var:v79"" select=""userCSharp:StringConcat($var:v78)"" />
            <xsl:variable name=""var:v80"" select=""string(Address/PostalAddress/State/text())"" />
            <xsl:variable name=""var:v81"" select=""userCSharp:StringConcat($var:v80)"" />
            <xsl:variable name=""var:v82"" select=""string(Address/PostalAddress/PostalCode/text())"" />
            <xsl:variable name=""var:v83"" select=""userCSharp:StringConcat($var:v82)"" />
            <xsl:variable name=""var:v84"" select=""string(Address/PostalAddress/Country/@isoCountryCode)"" />
            <xsl:variable name=""var:v85"" select=""userCSharp:StringConcat($var:v84)"" />
            <xsl:variable name=""var:v86"" select=""string(../BillTo/Address/Name/text())"" />
            <xsl:variable name=""var:v87"" select=""userCSharp:StringConcat($var:v86)"" />
            <xsl:variable name=""var:v88"" select=""string(../BillTo/Address/@addressID)"" />
            <xsl:variable name=""var:v89"" select=""userCSharp:StringConcat($var:v88)"" />
            <xsl:variable name=""var:v90"" select=""string(../BillTo/Address/PostalAddress/City/text())"" />
            <xsl:variable name=""var:v91"" select=""userCSharp:StringConcat($var:v90)"" />
            <xsl:variable name=""var:v92"" select=""string(../BillTo/Address/PostalAddress/State/text())"" />
            <xsl:variable name=""var:v93"" select=""userCSharp:StringConcat($var:v92)"" />
            <xsl:variable name=""var:v94"" select=""string(../BillTo/Address/PostalAddress/PostalCode/text())"" />
            <xsl:variable name=""var:v95"" select=""userCSharp:StringConcat($var:v94)"" />
            <xsl:variable name=""var:v96"" select=""string(../BillTo/Address/PostalAddress/Country/@isoCountryCode)"" />
            <xsl:variable name=""var:v97"" select=""userCSharp:StringConcat($var:v96)"" />
            <xsl:variable name=""var:v98"" select=""$var:v75"" />
            <xsl:variable name=""var:v99"" select=""$var:v56"" />
            <xsl:variable name=""var:v100"" select=""$var:v77"" />
            <xsl:variable name=""var:v101"" select=""$var:v58"" />
            <xsl:variable name=""var:v102"" select=""$var:v59"" />
            <xsl:variable name=""var:v103"" select=""$var:v79"" />
            <xsl:variable name=""var:v104"" select=""$var:v81"" />
            <xsl:variable name=""var:v105"" select=""$var:v83"" />
            <xsl:variable name=""var:v106"" select=""$var:v85"" />
            <xsl:variable name=""var:v107"" select=""$var:v64"" />
            <xsl:variable name=""var:v108"" select=""$var:v87"" />
            <xsl:variable name=""var:v109"" select=""$var:v89"" />
            <xsl:variable name=""var:v110"" select=""$var:v67"" />
            <xsl:variable name=""var:v111"" select=""$var:v68"" />
            <xsl:variable name=""var:v112"" select=""$var:v91"" />
            <xsl:variable name=""var:v113"" select=""$var:v93"" />
            <xsl:variable name=""var:v114"" select=""$var:v95"" />
            <xsl:variable name=""var:v115"" select=""$var:v97"" />
            <ns0:N1Loop1>
              <ns0:N1>
                <N101>
                  <xsl:value-of select=""$var:v73"" />
                </N101>
                <N102>
                  <xsl:value-of select=""$var:v98"" />
                </N102>
                <N103>
                  <xsl:value-of select=""$var:v99"" />
                </N103>
                <N104>
                  <xsl:value-of select=""$var:v100"" />
                </N104>
              </ns0:N1>
              <ns0:N3>
                <N301>
                  <xsl:value-of select=""$var:v101"" />
                </N301>
                <N302>
                  <xsl:value-of select=""$var:v102"" />
                </N302>
              </ns0:N3>
              <ns0:N4>
                <N401>
                  <xsl:value-of select=""$var:v103"" />
                </N401>
                <N402>
                  <xsl:value-of select=""$var:v104"" />
                </N402>
                <N403>
                  <xsl:value-of select=""$var:v105"" />
                </N403>
                <N404>
                  <xsl:value-of select=""$var:v106"" />
                </N404>
              </ns0:N4>
            </ns0:N1Loop1>
            <ns0:N1Loop1>
              <ns0:N1>
                <N101>
                  <xsl:value-of select=""$var:v107"" />
                </N101>
                <N102>
                  <xsl:value-of select=""$var:v108"" />
                </N102>
                <N103>
                  <xsl:value-of select=""$var:v99"" />
                </N103>
                <N104>
                  <xsl:value-of select=""$var:v109"" />
                </N104>
              </ns0:N1>
              <ns0:N3>
                <N301>
                  <xsl:value-of select=""$var:v110"" />
                </N301>
                <N302>
                  <xsl:value-of select=""$var:v111"" />
                </N302>
              </ns0:N3>
              <ns0:N4>
                <N401>
                  <xsl:value-of select=""$var:v112"" />
                </N401>
                <N402>
                  <xsl:value-of select=""$var:v113"" />
                </N402>
                <N403>
                  <xsl:value-of select=""$var:v114"" />
                </N403>
                <N404>
                  <xsl:value-of select=""$var:v115"" />
                </N404>
              </ns0:N4>
            </ns0:N1Loop1>
          </xsl:for-each>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:for-each select=""ItemOut"">
            <xsl:variable name=""var:v125"" select=""userCSharp:StringTrimRight(&quot;VC&quot;)"" />
            <xsl:variable name=""var:v126"" select=""userCSharp:StringTrimRight(&quot;BP&quot;)"" />
            <xsl:variable name=""var:v127"" select=""userCSharp:StringTrimRight(&quot;F&quot;)"" />
            <xsl:variable name=""var:v140"" select=""userCSharp:StringTrimRight(&quot;002&quot;)"" />
            <ns0:POCLoop1>
              <ns0:POC>
                <xsl:if test=""@lineNumber"">
                  <POC01>
                    <xsl:value-of select=""@lineNumber"" />
                  </POC01>
                </xsl:if>
                <xsl:for-each select=""ItemDetail"">
                  <xsl:for-each select=""Extrinsic"">
                    <xsl:variable name=""var:v116"" select=""string(@name)"" />
                    <xsl:variable name=""var:v117"" select=""userCSharp:LogicalEq($var:v116 , &quot;changeType&quot;)"" />
                    <xsl:if test=""string($var:v117)='true'"">
                      <xsl:variable name=""var:v118"" select=""./text()"" />
                      <POC02>
                        <xsl:value-of select=""$var:v118"" />
                      </POC02>
                    </xsl:if>
                  </xsl:for-each>
                </xsl:for-each>
                <POC03>
                  <xsl:value-of select=""@quantity"" />
                </POC03>
                <xsl:for-each select=""ItemDetail"">
                  <xsl:for-each select=""Extrinsic"">
                    <xsl:variable name=""var:v119"" select=""string(@name)"" />
                    <xsl:variable name=""var:v120"" select=""userCSharp:LogicalEq($var:v119 , &quot;qtyLeftToReceive&quot;)"" />
                    <xsl:if test=""string($var:v120)='true'"">
                      <xsl:variable name=""var:v121"" select=""./text()"" />
                      <POC04>
                        <xsl:value-of select=""$var:v121"" />
                      </POC04>
                    </xsl:if>
                  </xsl:for-each>
                </xsl:for-each>
                <ns0:C001_5>
                  <C00101>
                    <xsl:value-of select=""ItemDetail/UnitOfMeasure/text()"" />
                  </C00101>
                </ns0:C001_5>
                <POC06>
                  <xsl:value-of select=""ItemDetail/UnitPrice/Money/text()"" />
                </POC06>
                <xsl:for-each select=""ItemDetail"">
                  <xsl:for-each select=""Extrinsic"">
                    <xsl:variable name=""var:v122"" select=""string(@name)"" />
                    <xsl:variable name=""var:v123"" select=""userCSharp:LogicalEq($var:v122 , &quot;basisUnitPriceCode&quot;)"" />
                    <xsl:if test=""string($var:v123)='true'"">
                      <xsl:variable name=""var:v124"" select=""./text()"" />
                      <POC07>
                        <xsl:value-of select=""$var:v124"" />
                      </POC07>
                    </xsl:if>
                  </xsl:for-each>
                </xsl:for-each>
                <POC08>
                  <xsl:value-of select=""$var:v125"" />
                </POC08>
                <POC09>
                  <xsl:value-of select=""ItemID/SupplierPartID/text()"" />
                </POC09>
                <POC10>
                  <xsl:value-of select=""$var:v126"" />
                </POC10>
                <xsl:if test=""ItemID/SupplierPartAuxiliaryID"">
                  <POC11>
                    <xsl:value-of select=""ItemID/SupplierPartAuxiliaryID/text()"" />
                  </POC11>
                </xsl:if>
              </ns0:POC>
              <ns0:PIDLoop1>
                <ns0:PID_2>
                  <PID01>
                    <xsl:value-of select=""$var:v127"" />
                  </PID01>
                  <PID05>
                    <xsl:value-of select=""ItemDetail/Description/text()"" />
                  </PID05>
                </ns0:PID_2>
              </ns0:PIDLoop1>
              <xsl:for-each select=""ItemDetail"">
                <xsl:variable name=""var:v128"" select=""userCSharp:LogicalEq(string(Extrinsic/@name) , &quot;quoteNumber&quot;)"" />
                <xsl:if test=""string($var:v128)='true'"">
                  <xsl:variable name=""var:v129"" select=""Extrinsic/text()"" />
                  <xsl:variable name=""var:v130"" select=""userCSharp:StringSize(string($var:v129))"" />
                  <xsl:variable name=""var:v131"" select=""userCSharp:LogicalGt(string($var:v130) , &quot;0&quot;)"" />
                  <xsl:if test=""$var:v131"">
                    <xsl:variable name=""var:v138"" select=""string(Extrinsic/@name)"" />
                    <xsl:variable name=""var:v139"" select=""userCSharp:LogicalEq($var:v138 , &quot;quoteNumber&quot;)"" />
                    <ns0:REF_7>
                      <xsl:for-each select=""Extrinsic"">
                        <xsl:variable name=""var:v132"" select=""string(@name)"" />
                        <xsl:variable name=""var:v133"" select=""userCSharp:LogicalEq($var:v132 , &quot;quoteNumber&quot;)"" />
                        <xsl:if test=""string($var:v133)='true'"">
                          <xsl:variable name=""var:v134"" select=""./text()"" />
                          <xsl:variable name=""var:v135"" select=""userCSharp:StringSize(string($var:v134))"" />
                          <xsl:variable name=""var:v136"" select=""userCSharp:LogicalGt(string($var:v135) , &quot;0&quot;)"" />
                          <xsl:if test=""string($var:v136)='true'"">
                            <xsl:variable name=""var:v137"" select=""userCSharp:StringTrimRight(&quot;PR&quot;)"" />
                            <REF01>
                              <xsl:value-of select=""$var:v137"" />
                            </REF01>
                          </xsl:if>
                        </xsl:if>
                      </xsl:for-each>
                      <xsl:if test=""string($var:v139)='true'"">
                        <xsl:if test=""string($var:v131)='true'"">
                          <xsl:if test=""string($var:v139)='true'"">
                            <REF02>
                              <xsl:value-of select=""$var:v129"" />
                            </REF02>
                          </xsl:if>
                        </xsl:if>
                      </xsl:if>
                    </ns0:REF_7>
                  </xsl:if>
                </xsl:if>
              </xsl:for-each>
              <ns0:DTM_7>
                <DTM01>
                  <xsl:value-of select=""$var:v140"" />
                </DTM01>
                <xsl:if test=""@requestedDeliveryDate"">
                  <DTM03>
                    <xsl:value-of select=""@requestedDeliveryDate"" />
                  </DTM03>
                </xsl:if>
              </ns0:DTM_7>
              <xsl:for-each select=""ItemDetail"">
                <xsl:variable name=""var:v141"" select=""string(Extrinsic/@name)"" />
                <xsl:variable name=""var:v142"" select=""userCSharp:LogicalEq($var:v141 , &quot;comments&quot;)"" />
                <xsl:if test=""string($var:v142)='true'"">
                  <xsl:variable name=""var:v143"" select=""Extrinsic/text()"" />
                  <xsl:variable name=""var:v144"" select=""userCSharp:StringSize(string($var:v143))"" />
                  <xsl:variable name=""var:v145"" select=""userCSharp:LogicalGt(string($var:v144) , &quot;0&quot;)"" />
                  <xsl:if test=""$var:v145"">
                    <ns0:MSG_5>
                      <xsl:for-each select=""Extrinsic"">
                        <xsl:variable name=""var:v146"" select=""string(@name)"" />
                        <xsl:variable name=""var:v147"" select=""userCSharp:LogicalEq($var:v146 , &quot;comments&quot;)"" />
                        <xsl:if test=""string($var:v147)='true'"">
                          <xsl:variable name=""var:v148"" select=""./text()"" />
                          <xsl:variable name=""var:v149"" select=""userCSharp:StringSize(string($var:v148))"" />
                          <xsl:variable name=""var:v150"" select=""userCSharp:LogicalGt(string($var:v149) , &quot;0&quot;)"" />
                          <xsl:if test=""string($var:v150)='true'"">
                            <xsl:if test=""string($var:v147)='true'"">
                              <MSG01>
                                <xsl:value-of select=""$var:v148"" />
                              </MSG01>
                            </xsl:if>
                          </xsl:if>
                        </xsl:if>
                      </xsl:for-each>
                    </ns0:MSG_5>
                  </xsl:if>
                </xsl:if>
              </xsl:for-each>
            </ns0:POCLoop1>
          </xsl:for-each>
        </xsl:for-each>
      </xsl:for-each>
      <ns0:CTTLoop1>
        <ns0:CTT>
          <CTT01>
            <xsl:value-of select=""$var:v151"" />
          </CTT01>
        </ns0:CTT>
      </ns0:CTTLoop1>
    </ns0:X12_00401_860>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
}


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
}


public string StringConcat(string param0)
{
   return param0;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"EdiSchemas.cXML.cXML";
        
        private const global::EdiSchemas.cXML.cXML _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"EdiSchemas.X12.X12_00401_860";
        
        private const global::EdiSchemas.X12.X12_00401_860 _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltEngine {
            get {
                return _xsltEngine;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"EdiSchemas.cXML.cXML";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"EdiSchemas.X12.X12_00401_860";
                return _TrgSchemas;
            }
        }
    }
}
