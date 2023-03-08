namespace Outbound_PO_EDI_Pickup.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.cXML.cXML", typeof(global::EdiSchemas.cXML.cXML))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.X12.X12_00401_850", typeof(global::EdiSchemas.X12.X12_00401_850))]
    public sealed class PO_850_Map : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/cXML"" />
  </xsl:template>
  <xsl:template match=""/cXML"">
    <xsl:variable name=""var:v161"" select=""count(/cXML/Request/OrderRequest/ItemOut/ItemDetail)"" />
    <ns0:X12_00401_850>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimRight(&quot;850&quot;)"" />
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
          <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimRight(&quot;00&quot;)"" />
          <ns0:BEG>
            <BEG01>
              <xsl:value-of select=""$var:v2"" />
            </BEG01>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq(string(@name) , &quot;shipType&quot;)"" />
              <xsl:if test=""string($var:v3)='true'"">
                <xsl:variable name=""var:v4"" select=""./text()"" />
                <BEG02>
                  <xsl:value-of select=""$var:v4"" />
                </BEG02>
              </xsl:if>
            </xsl:for-each>
            <BEG03>
              <xsl:value-of select=""OrderRequestHeader/@orderID"" />
            </BEG03>
            <BEG05>
              <xsl:value-of select=""OrderRequestHeader/@orderDate"" />
            </BEG05>
          </ns0:BEG>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq(string(OrderRequestHeader/Extrinsic/@name) , &quot;customerPurchaseOrder&quot;)"" />
          <xsl:if test=""string($var:v5)='true'"">
            <xsl:variable name=""var:v6"" select=""OrderRequestHeader/Extrinsic/text()"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:StringSize(string($var:v6))"" />
            <xsl:variable name=""var:v8"" select=""userCSharp:LogicalGt(string($var:v7) , &quot;0&quot;)"" />
            <xsl:if test=""$var:v8"">
              <ns0:REF>
                <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
                  <xsl:variable name=""var:v9"" select=""string(@name)"" />
                  <xsl:variable name=""var:v10"" select=""userCSharp:LogicalEq($var:v9 , &quot;customerPurchaseOrder&quot;)"" />
                  <xsl:if test=""string($var:v10)='true'"">
                    <xsl:variable name=""var:v11"" select=""./text()"" />
                    <xsl:variable name=""var:v12"" select=""userCSharp:StringSize(string($var:v11))"" />
                    <xsl:variable name=""var:v13"" select=""userCSharp:LogicalGt(string($var:v12) , &quot;0&quot;)"" />
                    <xsl:variable name=""var:v14"" select=""userCSharp:StringTrimRight(&quot;CO&quot;)"" />
                    <xsl:if test=""string($var:v13)='true'"">
                      <xsl:variable name=""var:v15"" select=""string($var:v14)"" />
                      <REF01>
                        <xsl:value-of select=""$var:v15"" />
                      </REF01>
                    </xsl:if>
                  </xsl:if>
                </xsl:for-each>
                <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
                  <xsl:variable name=""var:v16"" select=""string(@name)"" />
                  <xsl:variable name=""var:v17"" select=""userCSharp:LogicalEq($var:v16 , &quot;customerPurchaseOrder&quot;)"" />
                  <xsl:if test=""string($var:v17)='true'"">
                    <xsl:variable name=""var:v18"" select=""./text()"" />
                    <xsl:variable name=""var:v19"" select=""userCSharp:StringSize(string($var:v18))"" />
                    <xsl:variable name=""var:v20"" select=""userCSharp:LogicalGt(string($var:v19) , &quot;0&quot;)"" />
                    <xsl:if test=""string($var:v17)='true'"">
                      <xsl:if test=""string($var:v20)='true'"">
                        <xsl:variable name=""var:v21"" select=""string($var:v18)"" />
                        <REF02>
                          <xsl:value-of select=""$var:v21"" />
                        </REF02>
                      </xsl:if>
                    </xsl:if>
                  </xsl:if>
                </xsl:for-each>
              </ns0:REF>
            </xsl:if>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:for-each select=""OrderRequestHeader/Contact"">
            <xsl:for-each select=""Phone"">
              <xsl:variable name=""var:v22"" select=""userCSharp:StringTrimRight(&quot;BD&quot;)"" />
              <xsl:variable name=""var:v23"" select=""userCSharp:LogicalEq(string(../@role) , &quot;purchasingAgent&quot;)"" />
              <xsl:variable name=""var:v25"" select=""userCSharp:StringTrimRight(&quot;TE&quot;)"" />
              <xsl:variable name=""var:v26"" select=""string(../@role)"" />
              <xsl:variable name=""var:v27"" select=""userCSharp:LogicalEq($var:v26 , &quot;purchasingAgent&quot;)"" />
              <xsl:variable name=""var:v32"" select=""userCSharp:StringTrimRight(&quot;EM&quot;)"" />
              <ns0:PER>
                <PER01>
                  <xsl:value-of select=""$var:v22"" />
                </PER01>
                <xsl:if test=""string($var:v23)='true'"">
                  <xsl:variable name=""var:v24"" select=""../Name/text()"" />
                  <PER02>
                    <xsl:value-of select=""$var:v24"" />
                  </PER02>
                </xsl:if>
                <PER03>
                  <xsl:value-of select=""$var:v25"" />
                </PER03>
                <xsl:if test=""string($var:v27)='true'"">
                  <xsl:variable name=""var:v28"" select=""TelephoneNumber/AreaOrCityCode/text()"" />
                  <xsl:variable name=""var:v29"" select=""userCSharp:StringTrimRight(&quot;-&quot;)"" />
                  <xsl:if test=""string($var:v27)='true'"">
                    <xsl:variable name=""var:v30"" select=""TelephoneNumber/Number/text()"" />
                    <xsl:variable name=""var:v31"" select=""userCSharp:StringConcat(string($var:v28) , string($var:v29) , string($var:v30))"" />
                    <PER04>
                      <xsl:value-of select=""$var:v31"" />
                    </PER04>
                  </xsl:if>
                </xsl:if>
                <PER05>
                  <xsl:value-of select=""$var:v32"" />
                </PER05>
                <xsl:for-each select=""../Email"">
                  <xsl:variable name=""var:v33"" select=""string(../@role)"" />
                  <xsl:variable name=""var:v34"" select=""userCSharp:LogicalEq($var:v33 , &quot;purchasingAgent&quot;)"" />
                  <xsl:if test=""string($var:v34)='true'"">
                    <xsl:variable name=""var:v35"" select=""./text()"" />
                    <PER06>
                      <xsl:value-of select=""$var:v35"" />
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
              <xsl:variable name=""var:v36"" select=""string(@name)"" />
              <xsl:variable name=""var:v37"" select=""userCSharp:LogicalEq($var:v36 , &quot;Payment_Terms&quot;)"" />
              <xsl:if test=""string($var:v37)='true'"">
                <xsl:variable name=""var:v38"" select=""./text()"" />
                <ITD12>
                  <xsl:value-of select=""$var:v38"" />
                </ITD12>
              </xsl:if>
            </xsl:for-each>
          </ns0:ITD>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:variable name=""var:v39"" select=""userCSharp:StringTrimRight(&quot;002&quot;)"" />
          <ns0:DTM>
            <DTM01>
              <xsl:value-of select=""$var:v39"" />
            </DTM01>
            <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
              <xsl:variable name=""var:v40"" select=""string(@name)"" />
              <xsl:variable name=""var:v41"" select=""userCSharp:LogicalEq($var:v40 , &quot;requestedDeliveryDate&quot;)"" />
              <xsl:if test=""string($var:v41)='true'"">
                <xsl:variable name=""var:v42"" select=""./text()"" />
                <DTM02>
                  <xsl:value-of select=""$var:v42"" />
                </DTM02>
              </xsl:if>
            </xsl:for-each>
          </ns0:DTM>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:variable name=""var:v43"" select=""string(OrderRequestHeader/Extrinsic/@name)"" />
          <xsl:variable name=""var:v44"" select=""userCSharp:LogicalEq($var:v43 , &quot;shipmentMethod&quot;)"" />
          <xsl:if test=""string($var:v44)='true'"">
            <xsl:variable name=""var:v45"" select=""OrderRequestHeader/Extrinsic/text()"" />
            <xsl:variable name=""var:v46"" select=""userCSharp:StringSize(string($var:v45))"" />
            <xsl:variable name=""var:v47"" select=""userCSharp:LogicalGt(string($var:v46) , &quot;0&quot;)"" />
            <xsl:if test=""$var:v47"">
              <ns0:TD5>
                <xsl:for-each select=""OrderRequestHeader/Extrinsic"">
                  <xsl:variable name=""var:v48"" select=""string(@name)"" />
                  <xsl:variable name=""var:v49"" select=""userCSharp:LogicalEq($var:v48 , &quot;shipmentMethod&quot;)"" />
                  <xsl:if test=""string($var:v49)='true'"">
                    <xsl:variable name=""var:v50"" select=""./text()"" />
                    <TD505>
                      <xsl:value-of select=""$var:v50"" />
                    </TD505>
                  </xsl:if>
                </xsl:for-each>
              </ns0:TD5>
            </xsl:if>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
      <ns0:N9Loop1>
        <xsl:for-each select=""Request"">
          <xsl:for-each select=""OrderRequest"">
            <xsl:variable name=""var:v51"" select=""userCSharp:StringSize(string(OrderRequestHeader/Comments/text()))"" />
            <xsl:variable name=""var:v52"" select=""userCSharp:LogicalGt(string($var:v51) , &quot;0&quot;)"" />
            <xsl:if test=""$var:v52"">
              <ns0:N9>
                <xsl:for-each select=""OrderRequestHeader/Comments"">
                  <xsl:variable name=""var:v53"" select=""userCSharp:StringSize(string(./text()))"" />
                  <xsl:variable name=""var:v54"" select=""userCSharp:LogicalGt(string($var:v53) , &quot;0&quot;)"" />
                  <xsl:variable name=""var:v55"" select=""userCSharp:StringTrimRight(&quot;L1&quot;)"" />
                  <xsl:if test=""string($var:v54)='true'"">
                    <xsl:variable name=""var:v56"" select=""string($var:v55)"" />
                    <N901>
                      <xsl:value-of select=""$var:v56"" />
                    </N901>
                  </xsl:if>
                </xsl:for-each>
                <xsl:for-each select=""OrderRequestHeader/Comments"">
                  <xsl:variable name=""var:v57"" select=""string(./text())"" />
                  <xsl:variable name=""var:v58"" select=""userCSharp:StringSize($var:v57)"" />
                  <xsl:variable name=""var:v59"" select=""userCSharp:LogicalGt(string($var:v58) , &quot;0&quot;)"" />
                  <xsl:variable name=""var:v60"" select=""userCSharp:StringTrimRight(&quot;GEN&quot;)"" />
                  <xsl:if test=""string($var:v59)='true'"">
                    <xsl:variable name=""var:v61"" select=""string($var:v60)"" />
                    <N902>
                      <xsl:value-of select=""$var:v61"" />
                    </N902>
                  </xsl:if>
                </xsl:for-each>
              </ns0:N9>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""Request"">
          <xsl:for-each select=""OrderRequest"">
            <xsl:variable name=""var:v62"" select=""string(OrderRequestHeader/Comments/text())"" />
            <xsl:variable name=""var:v63"" select=""userCSharp:StringSize($var:v62)"" />
            <xsl:variable name=""var:v64"" select=""userCSharp:LogicalGt(string($var:v63) , &quot;0&quot;)"" />
            <xsl:if test=""$var:v64"">
              <ns0:MSG>
                <xsl:for-each select=""OrderRequestHeader/Comments"">
                  <xsl:variable name=""var:v65"" select=""string(./text())"" />
                  <xsl:variable name=""var:v66"" select=""userCSharp:StringSize($var:v65)"" />
                  <xsl:variable name=""var:v67"" select=""userCSharp:LogicalGt(string($var:v66) , &quot;0&quot;)"" />
                  <xsl:if test=""string($var:v67)='true'"">
                    <xsl:variable name=""var:v68"" select=""./text()"" />
                    <MSG01>
                      <xsl:value-of select=""$var:v68"" />
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
            <xsl:variable name=""var:v69"" select=""userCSharp:StringTrimRight(&quot;ST&quot;)"" />
            <xsl:variable name=""var:v70"" select=""userCSharp:StringConcat(string(Address/Name/text()))"" />
            <xsl:variable name=""var:v71"" select=""userCSharp:StringTrimRight(&quot;92&quot;)"" />
            <xsl:variable name=""var:v72"" select=""userCSharp:StringConcat(string(Address/@addressID))"" />
            <xsl:variable name=""var:v73"" select=""Address/PostalAddress/Street[1]/text()"" />
            <xsl:variable name=""var:v74"" select=""Address/PostalAddress/Street[2]/text()"" />
            <xsl:variable name=""var:v75"" select=""userCSharp:StringConcat(string(Address/PostalAddress/City/text()))"" />
            <xsl:variable name=""var:v76"" select=""userCSharp:StringConcat(string(Address/PostalAddress/State/text()))"" />
            <xsl:variable name=""var:v77"" select=""userCSharp:StringConcat(string(Address/PostalAddress/PostalCode/text()))"" />
            <xsl:variable name=""var:v78"" select=""userCSharp:StringConcat(string(Address/PostalAddress/Country/@isoCountryCode))"" />
            <xsl:variable name=""var:v79"" select=""userCSharp:StringTrimRight(&quot;BT&quot;)"" />
            <xsl:variable name=""var:v80"" select=""userCSharp:StringConcat(string(../BillTo/Address/Name/text()))"" />
            <xsl:variable name=""var:v81"" select=""userCSharp:StringConcat(string(../BillTo/Address/@addressID))"" />
            <xsl:variable name=""var:v82"" select=""../BillTo/Address/PostalAddress/Street[1]/text()"" />
            <xsl:variable name=""var:v83"" select=""../BillTo/Address/PostalAddress/Street[2]/text()"" />
            <xsl:variable name=""var:v84"" select=""userCSharp:StringConcat(string(../BillTo/Address/PostalAddress/City/text()))"" />
            <xsl:variable name=""var:v85"" select=""userCSharp:StringConcat(string(../BillTo/Address/PostalAddress/State/text()))"" />
            <xsl:variable name=""var:v86"" select=""userCSharp:StringConcat(string(../BillTo/Address/PostalAddress/PostalCode/text()))"" />
            <xsl:variable name=""var:v87"" select=""userCSharp:StringConcat(string(../BillTo/Address/PostalAddress/Country/@isoCountryCode))"" />
            <xsl:variable name=""var:v88"" select=""$var:v69"" />
            <xsl:variable name=""var:v89"" select=""string(Address/Name/text())"" />
            <xsl:variable name=""var:v90"" select=""userCSharp:StringConcat($var:v89)"" />
            <xsl:variable name=""var:v91"" select=""string(Address/@addressID)"" />
            <xsl:variable name=""var:v92"" select=""userCSharp:StringConcat($var:v91)"" />
            <xsl:variable name=""var:v93"" select=""string(Address/PostalAddress/City/text())"" />
            <xsl:variable name=""var:v94"" select=""userCSharp:StringConcat($var:v93)"" />
            <xsl:variable name=""var:v95"" select=""string(Address/PostalAddress/State/text())"" />
            <xsl:variable name=""var:v96"" select=""userCSharp:StringConcat($var:v95)"" />
            <xsl:variable name=""var:v97"" select=""string(Address/PostalAddress/PostalCode/text())"" />
            <xsl:variable name=""var:v98"" select=""userCSharp:StringConcat($var:v97)"" />
            <xsl:variable name=""var:v99"" select=""string(Address/PostalAddress/Country/@isoCountryCode)"" />
            <xsl:variable name=""var:v100"" select=""userCSharp:StringConcat($var:v99)"" />
            <xsl:variable name=""var:v101"" select=""string(../BillTo/Address/Name/text())"" />
            <xsl:variable name=""var:v102"" select=""userCSharp:StringConcat($var:v101)"" />
            <xsl:variable name=""var:v103"" select=""string(../BillTo/Address/@addressID)"" />
            <xsl:variable name=""var:v104"" select=""userCSharp:StringConcat($var:v103)"" />
            <xsl:variable name=""var:v105"" select=""string(../BillTo/Address/PostalAddress/City/text())"" />
            <xsl:variable name=""var:v106"" select=""userCSharp:StringConcat($var:v105)"" />
            <xsl:variable name=""var:v107"" select=""string(../BillTo/Address/PostalAddress/State/text())"" />
            <xsl:variable name=""var:v108"" select=""userCSharp:StringConcat($var:v107)"" />
            <xsl:variable name=""var:v109"" select=""string(../BillTo/Address/PostalAddress/PostalCode/text())"" />
            <xsl:variable name=""var:v110"" select=""userCSharp:StringConcat($var:v109)"" />
            <xsl:variable name=""var:v111"" select=""string(../BillTo/Address/PostalAddress/Country/@isoCountryCode)"" />
            <xsl:variable name=""var:v112"" select=""userCSharp:StringConcat($var:v111)"" />
            <xsl:variable name=""var:v113"" select=""$var:v90"" />
            <xsl:variable name=""var:v114"" select=""$var:v71"" />
            <xsl:variable name=""var:v115"" select=""$var:v92"" />
            <xsl:variable name=""var:v116"" select=""$var:v73"" />
            <xsl:variable name=""var:v117"" select=""$var:v74"" />
            <xsl:variable name=""var:v118"" select=""$var:v94"" />
            <xsl:variable name=""var:v119"" select=""$var:v96"" />
            <xsl:variable name=""var:v120"" select=""$var:v98"" />
            <xsl:variable name=""var:v121"" select=""$var:v100"" />
            <xsl:variable name=""var:v127"" select=""$var:v79"" />
            <xsl:variable name=""var:v128"" select=""$var:v102"" />
            <xsl:variable name=""var:v129"" select=""$var:v104"" />
            <xsl:variable name=""var:v130"" select=""$var:v82"" />
            <xsl:variable name=""var:v131"" select=""$var:v83"" />
            <xsl:variable name=""var:v132"" select=""$var:v106"" />
            <xsl:variable name=""var:v133"" select=""$var:v108"" />
            <xsl:variable name=""var:v134"" select=""$var:v110"" />
            <xsl:variable name=""var:v135"" select=""$var:v112"" />
            <ns0:N1Loop1>
              <ns0:N1>
                <N101>
                  <xsl:value-of select=""$var:v88"" />
                </N101>
                <N102>
                  <xsl:value-of select=""$var:v113"" />
                </N102>
                <N103>
                  <xsl:value-of select=""$var:v114"" />
                </N103>
                <N104>
                  <xsl:value-of select=""$var:v115"" />
                </N104>
              </ns0:N1>
              <ns0:N3>
                <N301>
                  <xsl:value-of select=""$var:v116"" />
                </N301>
                <N302>
                  <xsl:value-of select=""$var:v117"" />
                </N302>
              </ns0:N3>
              <ns0:N4>
                <N401>
                  <xsl:value-of select=""$var:v118"" />
                </N401>
                <N402>
                  <xsl:value-of select=""$var:v119"" />
                </N402>
                <N403>
                  <xsl:value-of select=""$var:v120"" />
                </N403>
                <N404>
                  <xsl:value-of select=""$var:v121"" />
                </N404>
              </ns0:N4>
              <xsl:for-each select=""Address/PostalAddress"">
                <xsl:for-each select=""DeliverTo"">
                  <xsl:variable name=""var:v122"" select=""userCSharp:StringTrimRight(&quot;IC&quot;)"" />
                  <xsl:variable name=""var:v123"" select=""userCSharp:StringTrimRight(&quot;TE&quot;)"" />
                  <xsl:variable name=""var:v124"" select=""userCSharp:StringTrimRight(&quot;-&quot;)"" />
                  <xsl:variable name=""var:v125"" select=""userCSharp:StringConcat(string(../../Phone/TelephoneNumber/AreaOrCityCode/text()) , string($var:v124) , string(../../Phone/TelephoneNumber/Number/text()))"" />
                  <xsl:variable name=""var:v126"" select=""userCSharp:StringTrimRight(&quot;EM&quot;)"" />
                  <ns0:PER_2>
                    <PER01>
                      <xsl:value-of select=""$var:v122"" />
                    </PER01>
                    <PER02>
                      <xsl:value-of select=""./text()"" />
                    </PER02>
                    <PER03>
                      <xsl:value-of select=""$var:v123"" />
                    </PER03>
                    <PER04>
                      <xsl:value-of select=""$var:v125"" />
                    </PER04>
                    <PER05>
                      <xsl:value-of select=""$var:v126"" />
                    </PER05>
                    <xsl:if test=""../../Email"">
                      <PER06>
                        <xsl:value-of select=""../../Email/text()"" />
                      </PER06>
                    </xsl:if>
                  </ns0:PER_2>
                </xsl:for-each>
              </xsl:for-each>
            </ns0:N1Loop1>
            <ns0:N1Loop1>
              <ns0:N1>
                <N101>
                  <xsl:value-of select=""$var:v127"" />
                </N101>
                <N102>
                  <xsl:value-of select=""$var:v128"" />
                </N102>
                <N103>
                  <xsl:value-of select=""$var:v114"" />
                </N103>
                <N104>
                  <xsl:value-of select=""$var:v129"" />
                </N104>
              </ns0:N1>
              <ns0:N3>
                <N301>
                  <xsl:value-of select=""$var:v130"" />
                </N301>
                <N302>
                  <xsl:value-of select=""$var:v131"" />
                </N302>
              </ns0:N3>
              <ns0:N4>
                <N401>
                  <xsl:value-of select=""$var:v132"" />
                </N401>
                <N402>
                  <xsl:value-of select=""$var:v133"" />
                </N402>
                <N403>
                  <xsl:value-of select=""$var:v134"" />
                </N403>
                <N404>
                  <xsl:value-of select=""$var:v135"" />
                </N404>
              </ns0:N4>
              <xsl:for-each select=""Address/PostalAddress"">
                <xsl:for-each select=""DeliverTo"">
                  <xsl:variable name=""var:v136"" select=""userCSharp:StringTrimRight(&quot;IC&quot;)"" />
                  <xsl:variable name=""var:v137"" select=""userCSharp:StringTrimRight(&quot;TE&quot;)"" />
                  <xsl:variable name=""var:v138"" select=""userCSharp:StringTrimRight(&quot;-&quot;)"" />
                  <xsl:variable name=""var:v139"" select=""string(../../Phone/TelephoneNumber/AreaOrCityCode/text())"" />
                  <xsl:variable name=""var:v140"" select=""string(../../Phone/TelephoneNumber/Number/text())"" />
                  <xsl:variable name=""var:v141"" select=""userCSharp:StringConcat($var:v139 , string($var:v138) , $var:v140)"" />
                  <xsl:variable name=""var:v142"" select=""userCSharp:StringTrimRight(&quot;EM&quot;)"" />
                  <ns0:PER_2>
                    <PER01>
                      <xsl:value-of select=""$var:v136"" />
                    </PER01>
                    <PER02>
                      <xsl:value-of select=""./text()"" />
                    </PER02>
                    <PER03>
                      <xsl:value-of select=""$var:v137"" />
                    </PER03>
                    <PER04>
                      <xsl:value-of select=""$var:v141"" />
                    </PER04>
                    <PER05>
                      <xsl:value-of select=""$var:v142"" />
                    </PER05>
                    <xsl:if test=""../../Email"">
                      <PER06>
                        <xsl:value-of select=""../../Email/text()"" />
                      </PER06>
                    </xsl:if>
                  </ns0:PER_2>
                </xsl:for-each>
              </xsl:for-each>
            </ns0:N1Loop1>
          </xsl:for-each>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""Request"">
        <xsl:for-each select=""OrderRequest"">
          <xsl:for-each select=""ItemOut"">
            <xsl:variable name=""var:v143"" select=""userCSharp:StringTrimRight(&quot;VC&quot;)"" />
            <xsl:variable name=""var:v144"" select=""userCSharp:StringTrimRight(&quot;BP&quot;)"" />
            <xsl:variable name=""var:v145"" select=""userCSharp:StringTrimRight(&quot;&quot;)"" />
            <xsl:variable name=""var:v146"" select=""userCSharp:StringTrimRight(&quot;F&quot;)"" />
            <xsl:variable name=""var:v147"" select=""userCSharp:LogicalEq(string(ItemDetail/Extrinsic/@name) , &quot;quoteNumber&quot;)"" />
            <xsl:variable name=""var:v154"" select=""userCSharp:StringTrimRight(&quot;002&quot;)"" />
            <xsl:variable name=""var:v155"" select=""string(ItemDetail/Extrinsic/@name)"" />
            <xsl:variable name=""var:v156"" select=""userCSharp:LogicalEq($var:v155 , &quot;comments&quot;)"" />
            <ns0:PO1Loop1>
              <ns0:PO1>
                <xsl:if test=""@lineNumber"">
                  <PO101>
                    <xsl:value-of select=""@lineNumber"" />
                  </PO101>
                </xsl:if>
                <PO102>
                  <xsl:value-of select=""@quantity"" />
                </PO102>
                <PO103>
                  <xsl:value-of select=""ItemDetail/UnitOfMeasure/text()"" />
                </PO103>
                <PO104>
                  <xsl:value-of select=""ItemDetail/UnitPrice/Money/text()"" />
                </PO104>
                <PO106>
                  <xsl:value-of select=""$var:v143"" />
                </PO106>
                <PO107>
                  <xsl:value-of select=""ItemID/SupplierPartID/text()"" />
                </PO107>
                <PO108>
                  <xsl:value-of select=""$var:v144"" />
                </PO108>
                <xsl:if test=""ItemID/SupplierPartAuxiliaryID"">
                  <PO109>
                    <xsl:value-of select=""ItemID/SupplierPartAuxiliaryID/text()"" />
                  </PO109>
                </xsl:if>
                <PO110>
                  <xsl:value-of select=""$var:v145"" />
                </PO110>
                <PO112>
                  <xsl:value-of select=""$var:v145"" />
                </PO112>
              </ns0:PO1>
              <ns0:PIDLoop1>
                <ns0:PID_2>
                  <PID01>
                    <xsl:value-of select=""$var:v146"" />
                  </PID01>
                  <PID05>
                    <xsl:value-of select=""ItemDetail/Description/text()"" />
                  </PID05>
                </ns0:PID_2>
              </ns0:PIDLoop1>
              <xsl:if test=""string($var:v147)='true'"">
                <xsl:variable name=""var:v148"" select=""ItemDetail/Extrinsic/text()"" />
                <xsl:variable name=""var:v149"" select=""userCSharp:LogicalIsString(string($var:v148))"" />
                <xsl:if test=""$var:v149"">
                  <xsl:variable name=""var:v150"" select=""string(ItemDetail/Extrinsic/@name)"" />
                  <xsl:variable name=""var:v151"" select=""userCSharp:LogicalEq($var:v150 , &quot;quoteNumber&quot;)"" />
                  <xsl:variable name=""var:v152"" select=""userCSharp:StringTrimRight(&quot;PR&quot;)"" />
                  <ns0:REF_7>
                    <xsl:if test=""string($var:v151)='true'"">
                      <xsl:variable name=""var:v153"" select=""string($var:v152)"" />
                      <REF01>
                        <xsl:value-of select=""$var:v153"" />
                      </REF01>
                    </xsl:if>
                    <xsl:if test=""string($var:v151)='true'"">
                      <REF02>
                        <xsl:value-of select=""$var:v148"" />
                      </REF02>
                    </xsl:if>
                  </ns0:REF_7>
                </xsl:if>
              </xsl:if>
              <ns0:DTM_7>
                <DTM01>
                  <xsl:value-of select=""$var:v154"" />
                </DTM01>
                <xsl:if test=""@requestedDeliveryDate"">
                  <DTM02>
                    <xsl:value-of select=""@requestedDeliveryDate"" />
                  </DTM02>
                </xsl:if>
              </ns0:DTM_7>
              <xsl:if test=""string($var:v156)='true'"">
                <xsl:variable name=""var:v157"" select=""ItemDetail/Extrinsic/text()"" />
                <xsl:variable name=""var:v158"" select=""userCSharp:StringSize(string($var:v157))"" />
                <xsl:variable name=""var:v159"" select=""userCSharp:LogicalGt(string($var:v158) , &quot;0&quot;)"" />
                <xsl:if test=""$var:v159"">
                  <ns0:MSG_5>
                    <xsl:if test=""string($var:v156)='true'"">
                      <xsl:if test=""string($var:v156)='true'"">
                        <xsl:if test=""string($var:v159)='true'"">
                          <xsl:variable name=""var:v160"" select=""string($var:v157)"" />
                          <MSG01>
                            <xsl:value-of select=""$var:v160"" />
                          </MSG01>
                        </xsl:if>
                      </xsl:if>
                    </xsl:if>
                  </ns0:MSG_5>
                </xsl:if>
              </xsl:if>
            </ns0:PO1Loop1>
          </xsl:for-each>
        </xsl:for-each>
      </xsl:for-each>
      <ns0:CTTLoop1>
        <ns0:CTT>
          <CTT01>
            <xsl:value-of select=""$var:v161"" />
          </CTT01>
        </ns0:CTT>
      </ns0:CTTLoop1>
    </ns0:X12_00401_850>
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


public bool LogicalIsString(string val)
{
	return (val != null && val !="""");
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
        
        private const string _strTrgSchemasList0 = @"EdiSchemas.X12.X12_00401_850";
        
        private const global::EdiSchemas.X12.X12_00401_850 _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"EdiSchemas.X12.X12_00401_850";
                return _TrgSchemas;
            }
        }
    }
}
