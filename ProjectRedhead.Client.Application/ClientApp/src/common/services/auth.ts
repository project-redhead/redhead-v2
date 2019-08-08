import ConfigService, { Config } from './config';
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
			if (c === undefined) {
				alert('Invalid config');
				return;
			}

			let clientEndpointUrl = `${window.location.protocol}//${window.location.host}`;
			let challengeUrl = `${c.apiEndpointUrl}/auth/challenge/discord?returnUrl=${clientEndpointUrl}/login/callback`;

			window.location.href = challengeUrl;
		});
	}
}

export default new AuthService();
