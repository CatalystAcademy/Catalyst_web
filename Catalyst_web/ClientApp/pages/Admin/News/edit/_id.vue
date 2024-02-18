<template>
  <div>
    <form @submit.prevent="submitNewsForm" action="/assets/inc/sendemail.php">
      <input v-model="editData.titleArm" type="text" placeholder="Title in Armenian" name="titleArm">
      <input v-model="editData.titleEng" type="text" placeholder="Title in English" name="titleEng">
      <input v-model="editData.descriptionArm" type="text" placeholder="Description in Armenian" name="descriptionArm">
      <input v-model="editData.descriptionEng" type="text" placeholder="Description in English" name="descriptionEng">
      <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
    </form>
  </div>
</template>

<script>
  import https from 'https';

  export default {
    name: 'EditNews',
    data() {
      return {
        newsId: null,
        editData: { titleArm: '', titleEng: '',descriptionArm: '', descriptionEng: '' },
      };
    },
    async created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }

      // Check if a course ID is provided in the route parameters
      if (this.$route.params.id) {
        this.newsId = this.$route.params.id;
        await this.fetchNewsDetails();
      }
    },
    methods: {
      async fetchNewsDetails() {
        try {
          const response = await this.$axios.get(`/api/NewsDetails/${this.newsId}`);
          this.editData = { ...response.data };
        } catch (error) {
          console.error('Error fetching news details:', error);
        }
      },
      async submitNewsForm() {
        try {
          const response = await this.$axios.put(`/api/News/Edit/${this.newsId}`, this.editData);
          console.log("response", response);
          if (response) {
            this.$toasted.success('Edit successful!');
            // Redirect after a successful edit
            window.location = "/admin/News/List";
          }
        } catch (error) {
          // Handle error and display message
          this.$toasted.error('An error occurred. Please try again.');
        }
      },
    },
  };
</script>
