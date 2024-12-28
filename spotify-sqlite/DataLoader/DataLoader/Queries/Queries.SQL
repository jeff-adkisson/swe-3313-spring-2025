select
    album.AlbumId,
    artist.Name as Artist,
    album.Name as Album,
    album.ReleaseYear as Year,
    trackData.TrackCount as TrackCount,
    trackData.Language as Language,
    album.ArtworkUrl
from
    Artist artist inner join
    ArtistAlbum artistAlbum on artist.ArtistId = artistAlbum.ArtistId inner join
    Album album on artistAlbum.AlbumId = album.AlbumId inner join
    (
    select
    Count(*) as TrackCount,
    AlbumId,
    Language
    from
    Track
    group by
    AlbumId,
    Language
    ) trackData on album.AlbumId = trackData.AlbumId
where
    artist.Name = 'Taylor Swift'
order by
    album.ReleaseYear desc,
    album.Name asc;

select
    track.Name as Track,
    track.Popularity as Popularity,
    track.DurationMs as Duration,
    track.Language as Language,
    album.ArtworkUrl
from
    Album album inner join
    Track track on album.AlbumId = track.AlbumId
where
    album.AlbumId = '996F2B016E59CDC7676B70D672AB8A7D8DBD4BB4'
order by
    track.Popularity desc