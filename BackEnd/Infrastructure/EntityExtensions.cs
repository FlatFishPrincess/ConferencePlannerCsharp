using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public static class EntityExtensions
    {
        public static ConferenceDTO.SessionResponse MapSessionResponse(this Session session) =>
            new ConferenceDTO.SessionResponse
            {
                ID = session.ID,
                Title = session.Title,
                StartTime = session.StartTime,
                EndTime = session.EndTime,
                Speakers = session.SessionSpeakers?
                                  .Select(ss => new ConferenceDTO.Speaker
                                  {
                                      ID = ss.SpeakerID,
                                      Name = ss.Speaker.Name
                                  })
                                   .ToList(),
                TrackID = session.TrackID,
                Track = new ConferenceDTO.Track
                {
                    ID = session?.TrackID ?? 0,
                    Name = session.Track?.Name
                },
                Abstract = session.Abstract
            };

        public static ConferenceDTO.SpeakerResponse MapSpeakerResponse(this Speaker speaker) =>
            new ConferenceDTO.SpeakerResponse
            {
                ID = speaker.ID,
                Name = speaker.Name,
                Bio = speaker.Bio,
                WebSite = speaker.WebSite,
                Sessions = speaker.SessionSpeakers?
                    .Select(ss =>
                        new ConferenceDTO.Session
                        {
                            ID = ss.SessionID,
                            Title = ss.Session.Title
                        })
                    .ToList()
            };

        public static ConferenceDTO.AttendeeResponse MapAttendeeResponse(this Attendee attendee) =>
            new ConferenceDTO.AttendeeResponse
            {
                ID = attendee.ID,
                FirstName = attendee.FirstName,
                LastName = attendee.LastName,
                UserName = attendee.UserName,
                Sessions = attendee.SessionAttendees?
                    .Select(sa =>
                        new ConferenceDTO.Session
                        {
                            ID = sa.SessionID,
                            Title = sa.Session.Title,
                            StartTime = sa.Session.StartTime,
                            EndTime = sa.Session.EndTime
                        })
                    .ToList()
            };
    }
}
