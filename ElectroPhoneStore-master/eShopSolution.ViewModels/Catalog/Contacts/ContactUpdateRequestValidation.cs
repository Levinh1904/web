﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Contacts
{
    public class ContactUpdateRequestValidation : AbstractValidator<ContactUpdateRequest>
    {
        public ContactUpdateRequestValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Tên sản phẩm không được để trống")
               .MaximumLength(200).WithMessage("Tên không được quá 200 ký tự");

            RuleFor(x => x.Tille).NotEmpty().WithMessage("Chủ đề không được để trống")
               .MaximumLength(4000).WithMessage("Mô tả không được quá 4000 ký tự");


        }
    }
    
}