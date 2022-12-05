Imports Classica.Api
Imports Classica.Api.ObjAlbum
Imports Classica.Data.Repository2003
Imports Classica.Presto.Web
Imports ObjPrestoWeb
Imports FGS.Linq.Extensions.EntityFramework
Imports FGS.Linq.Extensions.Pagination

Public Class frmOmple

    Property mns As New List(Of String)

    'Property Titol = "Sobrevolar TPerformers"
    Property Titol = "Omplir TPersona"
    Property albumsFets As Integer = 0
    Property tracksfets As Integer = 0
    Property Objdb As New DbContextP2003
    Property db As p2023Entities = Objdb.db

    Private Sub OmplirTPersona()
        Using Objdb As New DbContextP2003
            Dim db = Objdb.db
            Dim ut As New ObjUtil.ObjUtil
            Dim composers = (From t In db.TComposer
                             Where t.ranking > 0
                             Select t Order By t.ranking).ToList

            For Each one In composers
                lb1.Text = one.name
                OmplirTPersonesFromComposerOne(one)
                DE()
            Next
        End Using
    End Sub

    Sub OmplirTPersonesFromComposerOne(one As TComposer)
        Dim fadies = Now.AddDays(5)
        If one.dateProcess IsNot Nothing AndAlso one.dateProcess > fadies Then
            Exit Sub
        End If
        Dim obj As New ObjWebScrap.ObjAM
        obj.Msg = Sub(msg As String)
                      lb3.Text = msg
                      'System.Threading.Thread.Sleep(500)
                      DE()
                  End Sub

        obj.MsgImatge = Sub(img As Image)
                            pb1.Image = img
                            DE()
                        End Sub

        obj.MsgUpdated = Sub(persona As TPersona)
                             If mns.Contains(persona.idMN) Then
                                 Exit Sub
                             End If
                             mns.Add(persona.idMN)
                             If persona.dataProces Is Nothing OrElse persona.dataProces < fadies Then
                                 lb3.Text = "Crida ProcesBio(obj, idPresto, persona, persona.bio)" & ":" & one.id
                                 DE()
                                 ProcesBio(obj, one.id, persona, persona.bio)
                             End If
                         End Sub

        lb3.Text = "Crida ObjWebScrap.ObjAM" & ":" & one.id
        DE()
        obj.SearchByArtistName(one.name)
    End Sub

    Function GetAllMnLinksFromBio(bio As String) As List(Of String)
        Dim resp As New List(Of String)
        Dim rest = bio
        Do Until rest = ""
            Dim p1 = rest.IndexOf("-mn")
            If p1 < 0 Then
                rest = ""
                Continue Do
            End If
            resp.Add(rest.Substring(p1 + 1, 12))
            rest = rest.Substring(p1 + 12)
        Loop
        Return resp
    End Function

    Sub ProcesBio(obj As ObjWebScrap.ObjAM, idpresto As Long, persona As TPersona, bio As String)
        Dim ll = GetAllMnLinksFromBio(bio)
        For Each l In ll
            obj.DoOneIdMN(l, False)
        Next
    End Sub

    Private Sub SobreVolarTPersones()
        Using Objdb As New DbContextP2003
            Dim db = Objdb.db
            Dim ut As New ObjUtil.ObjUtil
            Dim persones = (From t In db.TPersona
                            Order By t.imgBase64 Is Nothing
                            Select t).Take(10000)
            For Each one In persones
                bt.Text = one.name
                pb1.Image = ut.Base64ToImage(one.imgBase64)
                System.Threading.Thread.Sleep(600)
                DE()
            Next
        End Using
    End Sub

    Sub DoClick(sender As Object, e As EventArgs) Handles bt.Click
        bt.Enabled = False
        'SobreVolarTPersones()
        OmplirTPersona()
        bt.Enabled = True
        DE()
    End Sub

    Private Sub VerificaAlbums_Click(sender As Object, e As EventArgs)
        bt.Enabled = False
        VerificaAlbums()
        bt.Enabled = True
        DE()
    End Sub

    Sub OmpleLabels()
        Using db As New DbContextP2003
            Dim presto As New ObjPrestoWeb()
            presto.MsgImatge1 = Sub(img As Image)
                                    pb1.Image = img
                                End Sub
            presto.DoLoopLabelsPopulars()
        End Using
    End Sub

    Private Sub AddAlbumsFromArtists_Click(sender As Object, e As EventArgs)
        bt.Enabled = False
        OmpleAlbumsByArtistsNoTracks()
        bt.Enabled = True
        DE()
    End Sub

    Private Sub AlbumsPerPerformer_Click(sender As Object, e As EventArgs)
        bt.Enabled = False
        AlbumsPerformers()
        bt.Enabled = True
        DE()
    End Sub

    Private Sub OmpleLabels_Click(sender As Object, e As EventArgs)
        bt.Enabled = False
        OmpleLabels()
        bt.Enabled = True
        DE()
    End Sub

    Private Sub SetLabelsToAlbums_Click(sender As Object, e As EventArgs)
        bt.Enabled = False
        SetLabelToAlbums()
        bt.Enabled = True
        DE()
    End Sub


    Sub OmpleAlbumsByArtistsNoTracks()
        'TOT el pipeline 
        Using Objdb As New DbContextP2003
            Dim db = Objdb.db
            Dim ss = From t In db.TAlbum
                     Where t.processDate Is Nothing And Not db.TTrack.Any(Function(a) a.idAlbum = t.id)

            ProgressBar1.Maximum = ss.Count

            Dim fets As Boolean = False
            Do
                'Try
                OmpleAlbumsByArtistsNoTracksLoop(db, 1000, fets)
                'Catch exE As EOFException
                '    Exit Do
                'Catch ex As Exception
                '    Throw ex
                'End Try
            Loop While fets
        End Using
    End Sub

    Sub OmpleAlbumsByArtistsNoTracksLoop(db As p2023Entities, quants As Integer, fets As Boolean)
        fets = False
        Dim ss = (From t In db.TAlbum
                  Where t.processDate Is Nothing And
                      Not db.TTrack.Any(Function(a) a.idAlbum = t.id)).Take(quants).ToList
        Dim c = 0
        For Each one In ss
            OmpleAlbumsByArtistsNoTracksOne(db, one)
            c += 1
            fets = True
        Next
    End Sub

    Sub SetLabelToAlbums()
        Dim presto As New ObjPrestoWeb
        presto.Message = Sub(msg As String)
                             'bt.Text = msg
                         End Sub

        presto.MsgImageDeezer = Sub(img As Image)
                                    pb1.Image = img
                                End Sub

        presto.MsgImagePresto = Sub(img As Image)
                                    pb2.Image = img
                                End Sub

        presto.MsgPagina = Sub(numPagina As Integer, total As Integer)
                               lb1.Text = "Pàgina " & numPagina & " de " & total
                               DE()
                           End Sub

        presto.MsgButton = Sub(msg As String)
                               lb2.Text = msg
                               DE()
                           End Sub

        presto.MsgAddAlbumFets = Sub(quants As Integer)
                                     bt.Text = quants & " Album Fet"
                                     System.Threading.Thread.Sleep(1000)
                                     DE()
                                 End Sub

        presto.MsgDE = Sub()
                           DE()
                       End Sub

        presto.DoSetLabelAlbums()
    End Sub

    Sub AlbumsPerformers()
        Dim obj As New ObjPrestoWeb

        obj.MsgDE = Sub()
                        DE()
                    End Sub

        obj.Message = Sub(msg As String)
                          bt.Text = msg
                          DE()
                      End Sub

        obj.MsgArtistName = Sub(name As String)
                                lb3.Text = name
                                DE()
                            End Sub

        obj.MsgButton = Sub()

                        End Sub

        obj.MsgImageDeezer = Sub(img As Image)
                                 pb1.Image = img
                             End Sub

        obj.MsgImagePresto = Sub(img As Image)
                                 pb2.Image = img
                             End Sub

        obj.MsgPagina = Sub(numPagina As Integer, total As Integer)
                            lb1.Text = "Pàgina " & numPagina & " de " & total
                            DE()
                        End Sub


        obj.MsgAddTracksFets = Sub(quants As Integer)
                                   MaterialLabel1lb4.Text = "Tracks fets: " & tracksfets
                               End Sub

        obj.MsgAddAlbumFets = Sub(quants As Integer)
                                  albumsFets += quants
                                  MaterialLabel1lb4.Text = "Albums fets: " & albumsFets
                              End Sub

        obj.DoFromTPerformers()
    End Sub

    Sub AlbumsPerformersLoop(quants As Integer, ByRef trobat As Boolean)
        trobat = False
        Dim pp = (From t In db.TPersona
                  Where t.dataProces Is Nothing
                  Order By t.name).Take(quants).ToList

        For Each one In pp
            AlbumsPerformersOne(db, one)
            trobat = True
            one.dataProces = Now
            db.SaveChanges()
        Next
    End Sub

    Sub AlbumsPerformersOne(db As p2023Entities, one As TPersona)
        Dim obj As New Classica.Presto.Web.ObjPrestoWeb
        obj.DoFromTPerformers()
    End Sub

    Sub albumCallBacks(album As ObjAlbum, one As TAlbum, db As p2023Entities)
        album.MsgImageDeezer = Sub(img As Image)
                                   pb1.Image = img
                                   DE()
                               End Sub

        album.MsgImagePresto = Sub(img As Image)
                                   pb2.Image = img
                                   DE()
                               End Sub

        album.Message = Sub(msg As String)
                            bt.Text = msg
                            DE()
                        End Sub

        album.MsgNotInDeezer = Sub(msg As Boolean)
                                   If msg Then
                                       bt.Text = "NO TROBAT A DEEZER"
                                   End If
                                   one.notInDeezer = True
                                   db.SaveChanges()
                               End Sub

    End Sub
    Sub OmpleAlbumsByArtistsNoTracksOne(db As p2023Entities, one As TAlbum)
        lb1.Text = one.name
        pb1.ImageLocation = one.urlImage

        Dim album As New ObjAlbum(one.urlContent)

        albumCallBacks(album, one, db)

        album.ReCreaAlbum()

        ProgressBar1.Value += 1

        DE()

        one.processDate = Now

        db.SaveChanges()

    End Sub

    Sub VerificaAlbums()
        Using db As New Data.Repository2003.DbContextP2003
            Dim mydb = db.db.TAlbum.Where(Function(w) w.prestige > 0)
            ProgressBar1.Maximum = mydb.Count
            For Each one In mydb.OrderBy(Function(p) p.prestige)
                DoOneAlbum(one)
            Next
        End Using
    End Sub

    Function DoOneAlbum(t As TAlbum) As TAlbum
        lb1.Text = t.name
        lb2.Text = t.prestige
        pb1.ImageLocation = t.urlImage
        ProgressBar1.Value += 1
        DE()
        Return t
    End Function

    Sub DE()
        Application.DoEvents()
    End Sub

    Private Sub frmOmple_Load(sender As Object, e As EventArgs) Handles Me.Load
        bt.Text = Titol
        lb1.Text = ""
        lb2.Text = ""
    End Sub
End Class
