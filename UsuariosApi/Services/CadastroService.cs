using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UsuariosApi.Data.Dtos.Usuario;
using UsuariosApi.Data.Requests;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<CustomIdentityUser> _userManager;

        public CadastroService(
            IMapper mapper, 
            UserManager<CustomIdentityUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<Result> CadastraUsuario(CreateUsuarioDto createDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(createDto);
            
            CustomIdentityUser usuarioIdentity = _mapper.Map<CustomIdentityUser>(usuario);
            
            var resultadoIdentity = await _userManager.CreateAsync(usuarioIdentity, createDto.Password);

            await _userManager.AddToRoleAsync(usuarioIdentity, "regular");

            if (resultadoIdentity.Succeeded)
            {

                var code = _userManager.GenerateEmailConfirmationTokenAsync(usuarioIdentity).Result;

                // var encodedCode = HttpUtility.UrlEncode(code);

                // Lógica para enviar e-mail de confirmação ao usuário
//                _emailService.EnviarEmailDeConfirmacao(
//                    new [] { usuarioIdentity.Email },
//                    "Link de Ativação",
//                    usuarioIdentity.Id,
//                   encodedCode
//                    );

                return Result.Ok().WithSuccess(code);
            }
            return Result.Fail("Falha ao cadastrar usuário");

        }

        public Result AtivaContaUsuario(AtivaContaRequest request)
        {
            var identityUser = _userManager.Users.FirstOrDefault(u => u.Id == request.UsuarioId);
            var identityResult = _userManager.ConfirmEmailAsync(identityUser, request.CodigoDeAtivacao).Result;
            if (identityResult.Succeeded)
            {
                return Result.Ok();
            }
            return Result.Fail("Falha ao ativar conta de usuário");
        }
    }
}
