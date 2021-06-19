﻿using System.Collections.Generic;

namespace WinTlx.Languages
{
	class LanguageDeutsch
	{
		public static Language GetLng()
		{
			Language lng = new Language("de", "Deutsch");
			lng.Items = new Dictionary<LngKeys, string>
			{
				{ LngKeys.Start_Text, "Bitte beachte, dass dies ein Test- und Diagnose-Tool für das i-Telex-Netzwerk ist. " +
					"Die Teilnehmer habe reale Fernschreiber angeschlossen. " +
					"Sende bitte keine längeren Texte oder Spam an i-Telex-Nummern!" },

				{ LngKeys.NoFunction_ToolTip, "Noch nicht implementiert" },

				{ LngKeys.MainForm_SearchText, "Suchtext (Name oder Nummer)" },
				{ LngKeys.MainForm_SearchText_ToolTip, "Suchtext oder i-Telex-Nummer" },
				{ LngKeys.MainForm_SearchResult, "Suchergebnisse (auswählen)" },
				{ LngKeys.MainForm_SearchButton, "Suchen" },
				{ LngKeys.MainForm_SearchButton_ToolTip, "Auf Teilnehmer-Server suchen" },
				{ LngKeys.MainForm_Answerback, "Kennung" },
				{ LngKeys.MainForm_Answerback_ToolTip, "WinTlx Kennung" },
				{ LngKeys.MainForm_Address, "Adresse" },
				{ LngKeys.MainForm_Port, "Port" },
				{ LngKeys.MainForm_Extension, "Extension" },
				{ LngKeys.MainForm_PeerType,
					"0 - gelöscht\r\n" + 
					"1 - texting baudot / Hostname\r\n" +
					"2 - texting baudot / feste IP\r\n" +
					"3 - ascii texting / Hostname\r\n" +
					"4 - ascii texting / feste IP\r\n" +
					"5 - texting baudot / dyn. IP\r\n" +
					"6 - Emailadresse"
				},
				//{ LngKeys.MainForm_Itelex, "i-Telex" },
				//{ LngKeys.MainForm_ASCII, "ASCII" },
				{ LngKeys.MainForm_ConnectButton, "Verbinden" },
				{ LngKeys.MainForm_DisconnectButton, "Trennen" },
				//{ LngKeys.MainForm_Favorites, "Favoriten" },
				{ LngKeys.MainForm_SendWruButton, "WRU" },
				{ LngKeys.MainForm_SendHereisButton, "Hier ist" },
				{ LngKeys.MainForm_SendLettersButton, "Bu" },
				{ LngKeys.MainForm_SendFiguresButton, "Zi" },
				{ LngKeys.MainForm_SendReturnButton, "<" },
				{ LngKeys.MainForm_SendLinefeedButton, "\u2261" },
				{ LngKeys.MainForm_SendBellButton, "Klingel" },
				{ LngKeys.MainForm_SendNullButton, "NUL" },
				{ LngKeys.MainForm_SendNullButton_ToolTip, "Code32/NULL Zeichen senden" },
				{ LngKeys.MainForm_SendThirdLevelButton, "PYC" },
				{ LngKeys.MainForm_SendThirdLevelButton_ToolTip, "Umschalten auf 3. Ebene" },
				{ LngKeys.MainForm_LineLabel, "Zeile" },
				{ LngKeys.MainForm_ColumnLabel, "Spalte" },
				{ LngKeys.MainForm_ConnTimeLabel, "Verb.Zeit" },
				{ LngKeys.MainForm_IdleTimeLabel, "Inaktiv" },
				{ LngKeys.MainForm_ReceiveStatusOn, "Empfang ein" },
				{ LngKeys.MainForm_ReceiveStatusOff, "Empfang aus" },
				{ LngKeys.MainForm_SendBufferStatus, "Sendepuffer" },

				{ LngKeys.MainMenu_FileMenu, "Datei" },
				{ LngKeys.MainMenu_SaveBufferAsText, "Puffer als Text speichern" },
				{ LngKeys.MainMenu_SaveBufferAsImage, "Puffer als Grafik speichern" },
				{ LngKeys.MainMenu_ClearBuffer, "Puffer löschen" },
				{ LngKeys.MainMenu_Config, "Einstellungen" },
				{ LngKeys.MainMenu_Exit, "Beenden" },
				{ LngKeys.MainMenu_FavoritesMenu, "Favoriten" },
				{ LngKeys.MainMenu_OpenFavorites, "Favoriten öffnen" },
				{ LngKeys.MainMenu_ExtrasMenu, "Extras" },
				{ LngKeys.MainMenu_OpenTextEditor, "Text-Editor öffnen" },
				{ LngKeys.MainMenu_OpenTapePunchEditor, "Lochstreifen-Editor öffnen" },
				{ LngKeys.MainMenu_EyeballCharOnOff, "Bildlocher ein/aus" },
				{ LngKeys.MainMenu_TestPattern, "Prüftextsender öffnen" },
				{ LngKeys.MainMenu_OpenScheduler, "Scheduler öffnen" },
				{ LngKeys.MainMenu_ReceiveMenu, "Empfang" },
				{ LngKeys.MainMenu_ReceiveOnOff, "Empfang ein/aus" },
				{ LngKeys.MainMenu_UpdateSubscribeServer, "Teilnehmer-Server-Eintrag aktualisieren" },
				{ LngKeys.MainMenu_DebugMenu, "Debug" },
				{ LngKeys.MainMenu_OpenDebug, "Debug-Fenster öffnen" },
				{ LngKeys.MainMenu_AboutMenu, "Info" },
				{ LngKeys.MainMenu_About, "Info" },

				{ LngKeys.Setup_Setup, "Einstellungen" },
				{ LngKeys.Setup_General, "Allgemein" },
				{ LngKeys.Setup_Language, "Sprache / Language" },
				{ LngKeys.Setup_LogfilePath, "Logfile-Pfad" },
				{ LngKeys.Setup_Answerback, "Kennungsgeber" },
				{ LngKeys.Setup_IdleTimeout, "Inaktivitäts-Timeout (s)" },
				{ LngKeys.Setup_OutputSpeed, "Ausgabegeschw. (Baud)" },
				{ LngKeys.Setup_CodeSet, "Zeichensatz" },
				{ LngKeys.Setup_SubscribeServer, "Teilnehmer-Server" },
				{ LngKeys.Setup_SubscribeServerAddress, "Tln-Server-Adresse" },
				{ LngKeys.Setup_SubscribeServerPort, "Tln-Server-Port" },
				{ LngKeys.Setup_IncomingConnection, "Eingehende Verbindungen" },
				{ LngKeys.Setup_SubscribeServerPin, "Teilnehmer-Server-Pin*" },
				{ LngKeys.Setup_OwnTelexNumber, "Telex-Nummer*" },
				{ LngKeys.Setup_ExtensionNumber, "Extension-Nummer*" },
				{ LngKeys.Setup_LimitedClient, "Limited client (Centralex)" },
				{ LngKeys.Setup_LimitedClientActive, "Limited client aktiv" },
				{ LngKeys.Setup_IncomingLocalPort, "Lokaler Port" },
				{ LngKeys.Setup_IncomingPublicPort, "Öffentlicher Port" },
				{ LngKeys.Setup_ServerDataHint, "* Diese Daten müssen mit den im Teilnehmer-Server gespeicherten Daten übereinstimmen." },
				{ LngKeys.Setup_CancelButton, "Abbruch" },
				{ LngKeys.Setup_SaveButton, "Speichern" },

				{ LngKeys.SendFile_SendFile, "Textdatei senden" },
				{ LngKeys.SendFile_LoadFile, "Datei laden" },
				{ LngKeys.SendFile_LineLength, "Zeilenlänge" },
				{ LngKeys.SendFile_Cropping, "Begrenzung" },
				{ LngKeys.SendFile_CroppingRight, "rechts" },
				{ LngKeys.SendFile_CroppingCenter, "zentriert" },
				{ LngKeys.SendFile_CroppingLeft, "links" },
				{ LngKeys.SendFile_Convert, "Konvertieren" },
				{ LngKeys.SendFile_SendButton, "Senden" },
				{ LngKeys.SendFile_CancelButton, "Abbrechen" },

				{ LngKeys.TapePunch_TapePunchLong, "Lochstreifen Sender/Empfänger/Editor" },
				{ LngKeys.TapePunch_TapePunchShort, "Lochstreifeneditor" },
				{ LngKeys.TapePunch_RecvButton, "Empf" },
				{ LngKeys.TapePunch_RecvButton_ToolTip, "LS-Empfänger ein/aus" },
				{ LngKeys.TapePunch_SendButton, "Senden" },
				{ LngKeys.TapePunch_SendButton_ToolTip, "LS senden" },

				{ LngKeys.TapePunch_StopButton, "Stop" },
				{ LngKeys.TapePunch_StopButton_ToolTip, "LS senden abbrechen" },

				{ LngKeys.TapePunch_StepButton, "Schritt" },
				{ LngKeys.TapePunch_StepButton_ToolTip, "LS senden Einzelschritt" },

				{ LngKeys.TapePunch_ClearButton, "Löschen" },
				{ LngKeys.TapePunch_ClearButton_ToolTip, "LS löschen" },
				{ LngKeys.TapePunch_LoadButton, "Laden" },
				{ LngKeys.TapePunch_LoadButton_ToolTip, "LS aus Datei laden" },
				{ LngKeys.TapePunch_SaveButton, "Speichern" },
				{ LngKeys.TapePunch_SaveButton_ToolTip, "LS in Datei speichern" },
				{ LngKeys.TapePunch_EditButton, "Edit" },
				{ LngKeys.TapePunch_EditButton_ToolTip, "LS-Editor ein/aus" },
				{ LngKeys.TapePunch_InsertButton, "Einf" },
				{ LngKeys.TapePunch_InsertButton_ToolTip, "Einfügemodus ein/aus" },
				{ LngKeys.TapePunch_DeleteButton, "Lösch" },
				{ LngKeys.TapePunch_DeleteButton_ToolTip, "Zeichen löschen" },
				{ LngKeys.TapePunch_CropStartButton_ToolTip, "Alle Zeichen bis zur akt. Position löschen" },
				{ LngKeys.TapePunch_CropEndButton_ToolTip, "Alle Zeichen ab der akt. Position löschen" },
				{ LngKeys.TapePunch_CloseButton, "Schließen" },
				{ LngKeys.TapePunch_CodeLetters, "BU" },
				{ LngKeys.TapePunch_CodeFigures, "ZI" },
				{ LngKeys.TapePunch_CodeCarriageReturn, "<" },
				{ LngKeys.TapePunch_CodeLinefeed, "\u2261" },
				{ LngKeys.TapePunch_ReverseButton, "Spiegeln" },
				{ LngKeys.TapePunch_ReverseButton_ToolTip, "Bitcode spiegeln" },

				{ LngKeys.Scheduler_Scheduler, "Zeitplaner" },
				{ LngKeys.Scheduler_AddEntry, "Neuer Eintrag" },
				{ LngKeys.Scheduler_CopyEntry, "Eintrag kopieren" },
				{ LngKeys.Scheduler_DeleteEntry, "Eintrag löschen" },
				{ LngKeys.Scheduler_CloseButton, "Schliessen" },
				{ LngKeys.Scheduler_ActiveRow, "Aktiv" },
				{ LngKeys.Scheduler_SuccessRow, "Erfolg" },
				{ LngKeys.Scheduler_ErrorRow, "Fehler" },
				{ LngKeys.Scheduler_DateRow, "Datum" },
				{ LngKeys.Scheduler_TimeRow, "Zeit" },
				{ LngKeys.Scheduler_DestRow, "Nummer oder Host;Port;Extension" },
				{ LngKeys.Scheduler_FileRow, "Textdatei" },

				{ LngKeys.Message_Connected, "verbunden" },
				{ LngKeys.Message_Disconnected, "getrennt" },
				{ LngKeys.Message_Reject, "reject" },
				{ LngKeys.Message_IdleTimeout, "inaktivitaetstimeout" },
				{ LngKeys.Message_IncomingConnection, "eingehende verbindung" },
				{ LngKeys.Message_SubscribeServerError, "tln.-server-fehler" },
				{ LngKeys.Message_InvalidSubscribeServerData, "ungueltige tln.-server adresse oder port" },
				{ LngKeys.Message_QueryResult, "eintraege gefunden" },
				{ LngKeys.Message_ConnectNoAddress, "adresse fehlt" },
				{ LngKeys.Message_ConnectInvalidPort, "ungueltiger port" },
				{ LngKeys.Message_ConnectInvalidExtension, "ungueltige extension-nummer" },
				{ LngKeys.Message_ConnectionError, "verbindungsfehler" },
				{ LngKeys.Message_Pangram, "prall vom whisky flog quax den jet zu bruch. 1234567890/(:-),=?" },
				//{ LngKeys.Message_Pangram, "kaufen sie jede woche vier gute bequeme pelze xy 1234567890/(:-),=?" },
				{ LngKeys.Message_EyeballCharActive, "bildlocher aktiv - starte lochstreifenstanzer" },

				{ LngKeys.Editor_Header, "Text Editor" },
				{ LngKeys.Editor_Clear, "Löschen" },
				{ LngKeys.Editor_Load, "Laden" },
				{ LngKeys.Editor_Save, "Speichern" },
				{ LngKeys.Editor_Send, "Senden" },
				{ LngKeys.Editor_Close, "Schließen" },
				{ LngKeys.Editor_ConvBaudot, "Baudot" },
				{ LngKeys.Editor_ConvRtty, "RttyArt" },
				{ LngKeys.Editor_AlignBlock, "Block" },
				{ LngKeys.Editor_AlignLeft, "Links" },
				{ LngKeys.Editor_ShiftLeft, "<" },
				{ LngKeys.Editor_ShiftRight, ">" },
				{ LngKeys.Editor_LineNr, "Zl" },
				{ LngKeys.Editor_ColumnNr, "Sp" },
				{ LngKeys.Editor_CharWidth, "Breite:" },
				{ LngKeys.Editor_NotSavedHeader, "Speichern" },
				{ LngKeys.Editor_NotSavedMessage, "Der Editor-Text wurden nicht gespeichert. Jetzt speichern?" },
				{ LngKeys.Editor_LoadError, "Fehler beim Laden" },
				{ LngKeys.Editor_SaveError, "Fehler beim Speichern" },
				{ LngKeys.Editor_Error, "Fehler" },

				{ LngKeys.Favorites_Header, "Favoriten" },
				{ LngKeys.Favorites_FavoritesTab, "Favoriten" },
				{ LngKeys.Favorites_CallHistoryTab, "Letzte Anrufe" },
				{ LngKeys.Favorites_FavAddButton, "Neu" },
				{ LngKeys.Favorites_FavDeleteButton, "Löschen" },
				{ LngKeys.Favorites_FavDialButton, "Übernehmen" },
				{ LngKeys.Favorites_HistClearButton, "Löschen" },
				{ LngKeys.Favorites_HistDialButton, "Übernehmen" },
				{ LngKeys.Favorites_EntryNumber, "Nummer" },
				{ LngKeys.Favorites_EntryName, "Name" },
				{ LngKeys.Favorites_EntryAddress, "IP-Adresse" },
				{ LngKeys.Favorites_EntryPort, "Port" },
				{ LngKeys.Favorites_EntryDirectDial, "Durchwahl" },
				{ LngKeys.Favorites_EntryDate, "Zeit" },
				{ LngKeys.Favorites_EntryResult, "Result" },
				{ LngKeys.Favorites_ClearHistHeader, "Löschen" },
				{ LngKeys.Favorites_ClearHistMessage, "Letzte Anrufe löschen?" },

				{ LngKeys.TestPattern_Header, "Prüftextsender" },
				{ LngKeys.TestPattern_DamperTest, "Dämpfer-Test" },
				{ LngKeys.TestPattern_Selection, "Auswahl" },
				{ LngKeys.TestPattern_Count, "Anzahl" },
				{ LngKeys.TestPattern_Send, "Senden" },
				{ LngKeys.TestPattern_Ryry, "ryry" },
				{ LngKeys.TestPattern_Fox, "Fox" },
				{ LngKeys.TestPattern_Pelze, "Pelze" },
				{ LngKeys.TestPattern_Quax, "Quax" },
				{ LngKeys.TestPattern_Line, "Linie" },
				{ LngKeys.TestPattern_DateTime, "Datum/Zeit" },
			};

			return lng;
		}
	}
}
