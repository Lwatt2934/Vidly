﻿using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
      //  public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}