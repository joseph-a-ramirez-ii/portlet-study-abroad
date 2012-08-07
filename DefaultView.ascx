<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DefaultView.ascx.cs" Inherits="CUS.ICS.StudyAbroad.DefaultView" %>
<%@ Register TagPrefix="common" Assembly="Jenzabar.Common" Namespace="Jenzabar.Common.Web.UI.Controls" %>
<script language="javascript" type="text/javascript">
// <!CDATA[

function obsessive_onclick() {

}


// ]]>
</script>




<style type="text/css">
    .style1
    {
        width: 139px;
        
    }
    .left
    {
    	text-align: left;
    }
    .right
    {
    	text-align: right;
    }
    
    #pg0_V_mentaldesc
    {
        height: 25px;
        width: 644px;
    }
    
    </style>

<div class="pSection">
	<div class="pContent">
	


		<table id="table1" style="border: black 0px solid; width:627px; background-color:#eeeeee"
		cellspacing="1" cellpadding="3"> 
			<tr>
				<th class="style1">
					TLU ID</th>
                <td>
						<asp:TextBox id="tluid" ReadOnly="true" runat="server" Width="100"></asp:TextBox>
				</td>
				<th class="style1">
					Curr Yr</th>
                <td>
						<asp:TextBox id="curr_yr" ReadOnly="true" runat="server" Width="100"></asp:TextBox>
				</td>
                <th class="style1">
					Curr Trm</th>
                <td>
						<asp:TextBox id="curr_trm" ReadOnly="true" runat="server" Width="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<th class="style1">
					Last Name</th>
				<td>
					<ASP:TEXTBOX id="lname" ReadOnly="true" runat="server" Width="100"></ASP:TEXTBOX>
				
				</td>
				<th>
					First Name</th>
				<td>
					<ASP:TEXTBOX id="fname" ReadOnly="True" runat="server" Width="100"></ASP:TEXTBOX></td>
				<th>
					Middle Name</th>
				<td>
					<ASP:TEXTBOX id="mname" ReadOnly="True" runat="server" Width="104px"></ASP:TEXTBOX></td>
			</tr>
			<tr>
				<th>
					Phone(H)</th>
				<td>
					<ASP:TEXTBOX id="hphone" ReadOnly="True" runat="server" Width="100"></ASP:TEXTBOX></td>
				<th>
					Phone(Cell)</th>
				<td>
					<ASP:TEXTBOX id="cphone" ReadOnly="True" runat="server" Width="100"></ASP:TEXTBOX></td>
				<th>
					Email</th>
				<td>
					<ASP:TEXTBOX id="email" ReadOnly="True" runat="server" Width="104px" MaxLength="2" 
                        Height="22px"></ASP:TEXTBOX></td>
			</tr>
			<tr>
			    <th>
					Campus Address</th>
				<td colspan="5">
					<ASP:TEXTBOX id="campaddr" ReadOnly="True" runat="server" Width="472px"></ASP:TEXTBOX>
		
				</td>
			</tr>
            <tr>
			    <th>
					Local Address</th>
				<td colspan="5">
					<ASP:TEXTBOX id="locaddr" ReadOnly="True" runat="server" Width="472px"></ASP:TEXTBOX>
		
				</td>
			</tr>
			<tr>
				<th>
					City</th>
				<td>
					<ASP:TEXTBOX id="campcity" ReadOnly="True" runat="server" Width="100"></ASP:TEXTBOX></td>
				<th>
					State</th>
				<td>
					<ASP:TEXTBOX id="campst" ReadOnly="True" runat="server" Width="100"></ASP:TEXTBOX></td>
				<th>
					Zip</th>
				<td>
					<ASP:TEXTBOX id="campzip" ReadOnly="True" runat="server" Width="104px" MaxLength="2" 
                        Height="22px"></ASP:TEXTBOX></td>
			</tr>
			<tr>
			    <th>
					Permanent Address</th>
				<td colspan="5">
					<ASP:TEXTBOX id="permaddr" ReadOnly="True" runat="server" Width="472px"></ASP:TEXTBOX>
		
				</td>
			</tr>
			<tr>
				<th>
					City</th>
				<td>
					<ASP:TEXTBOX id="permcity" ReadOnly="True" runat="server" Width="100"></ASP:TEXTBOX></td>
				<th>
					State</th>
				<td>
					<ASP:TEXTBOX id="permst" ReadOnly="True" runat="server" Width="100"></ASP:TEXTBOX></td>
				<th>
					Zip</th>
				<td>
					<ASP:TEXTBOX id="permzip" ReadOnly="True" runat="server" Width="104px" MaxLength="2" 
                        Height="22px"></ASP:TEXTBOX></td>
			</tr>
			<tr>
				<td colspan="6">
					<hr/>
				</td>
			</tr>
			<tr>
				<td colspan="6">
					<hr/>
				</td>
			</tr>
			
			
			<tr>
				
			    <th style="BORDER-BOTTOM: gray 1px solid" align="center" colspan="6">
				<asp:label id="lblError" Runat="server" ForeColor="Red" BackColor="Yellow" />
					<br />
					<ASP:BUTTON OnClick="btnSubmit_Click" id="btnSubmit" runat="server" text="Submit">
					
					</ASP:BUTTON><br />
					
                        
					
				</th>
				
			</tr>
		</table>
		
	 
      <br />

 

	    <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
	    
	</div>

</div>
<p>
    &nbsp;</p>
