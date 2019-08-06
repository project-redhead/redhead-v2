import ConfigService from './config';
export class AuthService {
	setToken(token: string) {
		localStorage.setItem('redhead_token', token);
	}

	getToken(): string | null {
		return localStorage.getItem('redhead_token');
	}

	isTokenValid(): boolean {
		let result = this.getToken() !== null;
		return result;
	}

	redirectToLogin() {
		ConfigService.getConfig().then(c => {
			window.location.href = `${c.apiBaseUrl}/auth/challenge/discord?returnUrl=${window.location.host}/login/callback`;
		});
	}
}

export default new AuthService();
