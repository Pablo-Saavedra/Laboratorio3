﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="textFecha.ascx.cs" Inherits="PracticaFinal7.textFecha" %>
<asp:TextBox ID="fecha" runat="server" TextMode="Date"></asp:TextBox><asp:CustomValidator ID="validaFecha" runat="server" ErrorMessage="La fecha ingresada no es valida" OnServerValidate="fechaNoValida"></asp:CustomValidator><asp:CustomValidator ID="validaCheckMarcado" runat="server" ErrorMessage="La fecha es obligatoria" OnServerValidate="fechaObligatoria"></asp:CustomValidator>