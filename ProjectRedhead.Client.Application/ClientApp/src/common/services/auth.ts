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
}

export default new AuthService();
