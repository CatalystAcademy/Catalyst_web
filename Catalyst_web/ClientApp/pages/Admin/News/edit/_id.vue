<template>
  <div>
    <form @submit.prevent="submitNewsForm" action="/assets/inc/sendemail.php">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="titleArm">Title in Armenian</label>
            <input v-model="editData.titleArm" type="text" placeholder="Title in Armenian" name="titleArm">
          </div>

          <div class="col">
            <label for="titleEng">Title in English</label>
            <input v-model="editData.titleEng" type="text" placeholder="Title in english" name="titleEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="descriptionArm">Description in Armenian</label>
            <textarea rows="4" cols="50" v-model="editData.descriptionArm" type="text" placeholder="Description in Armenian" name="descriptionArm"></textarea>
          </div>

          <div class="col">
            <label for="descriptionEng">Description in English</label>
            <textarea rows="4" cols="50" v-model="editData.descriptionEng" type="text" placeholder="Description in english" name="descriptionEng"></textarea>
          </div>
        </div>
        <div class="row">
          <div class="col">
            <label for="tag">Tags</label>
            <input v-model="editData.tag" type="text" placeholder="tags" name="tag">
          </div>
        </div>
      <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
      </div>
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
        editData: { titleArm: '', titleEng: '',descriptionArm: '', descriptionEng: '', tag: '' },
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

<style scoped>
  .form-group {
    margin-bottom: 20px;
  }

  .row {
    display: flex;
    justify-content: space-between;
    margin-bottom: 10px;
  }

  .col {
    flex: 0 0 48%; /* Adjust the width as needed */
  }

  label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
  }

  input,
  textarea,
  select {
    width: 100%;
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
    margin-top: 5px;
  }
</style>
