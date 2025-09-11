function limparCache() { // Função para limpar o cache do navegador
    if ('caches' in window) { // Verifica se o objeto caches está disponível
        caches.keys().then(function (names) { // Obtém todas as chaves de cache
            for (let name of names) { // Itera sobre cada chave
                caches.delete(name); // Exclui o cache correspondente à chave
            }
        });
    }
}

localStorage.clear(); // Limpa o localStorage
sessionStorage.clear(); // Limpa o sessionStorage
location.reload(true); // Recarrega a página ignorando o cache