using Teste.Domain.Commands.Nivel;
using Teste.Domain.Entities;
using Teste.Domain.IRepository;
using Teste.Shared.Entities;
using Teste.Shared.Interfaces;

namespace TesteAPI.Domain.Handlers
{
    public class NivelCommandHandler : ICommandHandler<CriarNivelCommand>,
        ICommandHandler<EditarNivelCommand>,
        ICommandHandler<RemoverNivelCommand>
    {

        private readonly INivelRepository _nivelRepository;
        private readonly IDesenvolvedorRepository _desenvolvedorRepository;

        public NivelCommandHandler(INivelRepository nivelRepository, IDesenvolvedorRepository desenvolvedorRepository)
        {
            _nivelRepository = nivelRepository;
            _desenvolvedorRepository = desenvolvedorRepository;
        }

        public ICommandResult Handle(CriarNivelCommand command)
        {
            var nivel = new Nivel(command.Nome);

            _nivelRepository.Salvar(nivel);

            return new CommandResult(true, "Nível criado com sucesso");

        }

        public ICommandResult Handle(EditarNivelCommand command)
        {
            var nivel = _nivelRepository.ObterPorId(command.Id);

            if (nivel == null)
            {
                return new CommandResult(false, "Não foi possível editar o nível.");
            }

            nivel.Alterar(command.Nome);
            _nivelRepository.Atualizar(nivel);
            return new CommandResult(true, "Nível editado com sucesso");
        }

        public ICommandResult Handle(RemoverNivelCommand command)
        {
            var nivel = _nivelRepository.ObterPorId(command.Id);

            if (nivel == null)
            {
                return new CommandResult(false, "Não foi possível remover o nível.");
            }

            var desenvolvedor = _desenvolvedorRepository.ExisteDesenvolvedorComNivel(nivel.Id);

            if (desenvolvedor)
            {
                return new CommandResult(false, "Não foi possível remover o nível, existem desenvolvedor associado a este.");
            }

            _nivelRepository.Remover(nivel.Id);
            return new CommandResult(true, "Nível removido com sucesso");
        }
    }
}
